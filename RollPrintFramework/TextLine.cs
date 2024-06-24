using RollPrintFramework;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows;

namespace RollPrintFramework
{
    public class TextLine : CanvasItem
    {
        private string _text;
        private Align _align;
        private Font _font;

        public string Text { get { return _text; } set { _text = value; } }
        public Align Align { get { return _align; } set { _align = value; } }
        public Font Font { get { return _font; } set { _font = value; } }

        public override void Draw(int upperMargin = 0)
        {
            Bitmap.SetResolution(Consts.dpi, Consts.dpi);
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                StringFormat strfmt = new StringFormat();
                strfmt.FormatFlags = StringFormatFlags.NoClip;

                RectangleF textSize = new RectangleF(new PointF(0, 0), g.MeasureString(_text, _font, Consts.RollWidth));
                Bitmap textLine = new Bitmap((int)textSize.Width, (int)textSize.Height);
                Bitmap res = new Bitmap(Consts.RollWidth, textLine.Height + upperMargin);
                textLine.SetResolution(Consts.dpi, Consts.dpi);
                res.SetResolution(Consts.dpi, Consts.dpi);
                using (Graphics gr = Graphics.FromImage(textLine))
                {
                    gr.TextRenderingHint = TextRenderingHint.AntiAlias;
                    //gr.FillRectangle(new SolidBrush(BackColor), 0, 0, textLine.Width, textLine.Height);
                    if (_align == Align.Center) { strfmt.Alignment = StringAlignment.Center; gr.DrawString(_text, _font, new SolidBrush(Consts.mainColor), textSize, strfmt); }
                    else if (_align == Align.Left) { strfmt.Alignment = StringAlignment.Near; gr.DrawString(_text, _font, new SolidBrush(Consts.mainColor), textSize, strfmt); }
                    else { strfmt.Alignment = StringAlignment.Far; gr.DrawString(_text, _font, new SolidBrush(Consts.mainColor), textSize, strfmt); }
                    gr.Flush();
                    gr.Dispose();
                }
                using (Graphics gra = Graphics.FromImage(res))
                {
                    gra.FillRectangle(new SolidBrush(BackColor), 0, 0, res.Width, res.Height);
                    if (_align == Align.Center) gra.DrawImage(textLine, res.Width / 2 - textLine.Width / 2, upperMargin);
                    else if (_align == Align.Left) gra.DrawImage(textLine, 0, upperMargin);
                    else gra.DrawImage(textLine, res.Width - textLine.Width, upperMargin);
                    gra.Flush(); gra.Dispose(); Bitmap = res;
                }
            }
        }

        public TextLine(string text, Align align, Font font, int position)
        {
            Type = "Текст";
            Position = position;
            base.GenInfoText(text);
            Text = text;
            Align = align;
            Font = font;
        }

        public TextLine() { }
    }
}
