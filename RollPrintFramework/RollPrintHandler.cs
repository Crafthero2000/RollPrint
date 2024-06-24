using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace RollPrintFramework
{
    public class RollPrintHandler
    {
        public class CanvasItemCollection<T> : ObservableCollection<T> { }
        private Bitmap imageToPrint;
        private const int dpi = 200;
        private static Color mainColor = Color.Black;
        private Color _paperColor = Color.White;
        private static Canvas _drawArea;
        private int _upperMargin;

        private static CanvasItemCollection<CanvasItem> _canvasItems = new CanvasItemCollection<CanvasItem>();
        public CanvasItemCollection<CanvasItem> Items { get { return _canvasItems; } set { _canvasItems = value; } }
        public Color PaperColor
        {
            get
            {
                if (_paperColor == Color.FromArgb(255, 250, 176))
                    return Color.Yellow;
                else if (_paperColor == Color.FromArgb(238, 186, 178))
                    return Color.Pink;
                else if (_paperColor == Color.FromArgb(214, 239, 237))
                    return Color.Blue;
                else
                    return _paperColor;
            }
            set
            {
                if (value == Color.Yellow)
                    _paperColor = Color.FromArgb(255, 250, 176);
                else if (value == Color.Pink)
                    _paperColor = Color.FromArgb(238, 186, 178);
                else if (value == Color.Blue)
                    _paperColor = Color.FromArgb(214, 239, 237);
                else
                    _paperColor = value;

                GenerateFinalImage();
            }
        }
        public Bitmap ImageToPrint { get { return imageToPrint; } set { imageToPrint = value; } }
        public int UpperMargin { get { return _upperMargin; } set { _upperMargin = Consts.Millimeters(value); } }

        public void GenerateFinalImage()
        {
            Bitmap upCut = (Bitmap)Resources.ResourceManager.GetObject("ReceiptCutUp_" + PaperColor.Name);
            Bitmap downCut = (Bitmap)Resources.ResourceManager.GetObject("ReceiptCutDown_" + PaperColor.Name);
            int resH = upCut.Height + downCut.Height;
            int contentH = 0;
            // if any canvas item exists draw content
            try
            {
                foreach (var item in _canvasItems)
                {
                    //if (item != _canvasItems.Last()) { resH += upperMargin; contentH += upperMargin; }
                    item.BackColor = _paperColor;
                    item.Draw(item == _canvasItems.First() ? 0 : _upperMargin);
                    resH += item.Bitmap.Height;
                    contentH += item.Bitmap.Height;
                }
                Bitmap content = new Bitmap(Consts.RollWidth, contentH);
                Bitmap contentPrint = new Bitmap(Consts.RollWidth, contentH);
                Bitmap result = new Bitmap(Consts.RollWidth, resH);
                content.SetResolution(dpi, dpi);
                contentPrint.SetResolution(dpi, dpi);
                result.SetResolution(dpi, dpi);

                using (Graphics g = Graphics.FromImage(content))
                {
                    int currentHeight = 0;
                    foreach (var item in _canvasItems)
                    {
                        g.DrawImage(item.Bitmap, new Point(0, currentHeight));
                        if (item != _canvasItems.Last()) currentHeight += item.Bitmap.Height;
                    }
                    g.DrawLine(new Pen(mainColor, 3f), new PointF(content.GetBounds(ref Consts.gU).Left + 1.5f, content.GetBounds(ref Consts.gU).Top), new PointF(content.GetBounds(ref Consts.gU).Left + 1.5f, content.GetBounds(ref Consts.gU).Bottom));
                    g.DrawLine(new Pen(mainColor, 3f), new PointF(content.GetBounds(ref Consts.gU).Right - 1.5f, content.GetBounds(ref Consts.gU).Top), new PointF(content.GetBounds(ref Consts.gU).Right - 1.5f, content.GetBounds(ref Consts.gU).Bottom));

                    g.Flush();
                    g.Dispose();
                }

                using (Graphics g = Graphics.FromImage(contentPrint))
                {
                    int currentHeight = 0;
                    foreach (var item in _canvasItems)
                    {
                        item.BackColor = Color.White;
                        item.Draw(item == _canvasItems.First() ? 0 : _upperMargin);
                        g.DrawImage(item.Bitmap, new Point(0, currentHeight));
                        if (item != _canvasItems.Last()) currentHeight += item.Bitmap.Height;
                    }
                    g.Flush();
                    g.Dispose();
                }

                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(upCut, 0, 0);
                    g.DrawImage(content, 0, upCut.Height);
                    g.DrawImage(downCut, 0, content.Height + upCut.Height);
                    g.Flush();
                    g.Dispose();
                }
                _drawArea.Image = result;
                imageToPrint = contentPrint;
            }
            // if canvas items don't exist draw blank page
            catch (ArgumentException)
            {
                Bitmap result = new Bitmap(Consts.RollWidth, resH + Consts.Millimeters(20));
                Bitmap contentPrint = new Bitmap(Consts.RollWidth, Consts.Millimeters(20));
                result.SetResolution(dpi, dpi);
                contentPrint.SetResolution(dpi, dpi);
                using (Graphics g = Graphics.FromImage(contentPrint))
                {
                    g.FillRectangle(new SolidBrush(_paperColor), 0, 0, contentPrint.Width, contentPrint.Height);
                    g.DrawLine(new Pen(mainColor, 3f), new PointF(contentPrint.GetBounds(ref Consts.gU).Left + 1.5f, contentPrint.GetBounds(ref Consts.gU).Top), new PointF(contentPrint.GetBounds(ref Consts.gU).Left + 1.5f, contentPrint.GetBounds(ref Consts.gU).Bottom));
                    g.DrawLine(new Pen(mainColor, 3f), new PointF(contentPrint.GetBounds(ref Consts.gU).Right - 1.5f, contentPrint.GetBounds(ref Consts.gU).Top), new PointF(contentPrint.GetBounds(ref Consts.gU).Right - 1.5f, contentPrint.GetBounds(ref Consts.gU).Bottom));
                    g.Flush();
                    g.Dispose();
                }
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(upCut, 0, 0);
                    g.DrawImage(contentPrint, 0, upCut.Height);
                    g.DrawImage(downCut, 0, contentPrint.Height + upCut.Height);
                    g.Flush();
                    g.Dispose();
                }
                _drawArea.Image = result;
                imageToPrint = contentPrint;
            }
        }

        public void AddTextLine(string text, Align align, Font font)
        {
            Items.Add(new TextLine(text, align, font, Items.Count + 1));
        }

        public void AddQRCode(string data, int size)
        {
            Items.Add(new QR(data, size, Items.Count + 1));
        }

        public void AddIcon(string origin)
        {
            Items.Add(new Picture(origin, Items.Count + 1));
        }

        public void AddSeparator()
        {
            Items.Add(new SeparatorLine(Items.Count + 1));
        }

        public RollPrintHandler(Canvas canvas, int upperMargin = 1) { _drawArea = canvas; UpperMargin = upperMargin; }
    }
}
