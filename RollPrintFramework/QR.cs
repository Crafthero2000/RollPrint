using QRCoder;
using System.Drawing;

namespace RollPrintFramework
{
    public class QR : CanvasItem
    {
        private string _data;
        public string Data { get { return _data; } set { _data = value; } }

        private int _size = 0;
        public int Size { get { return _size; } set { _size = value; } }

        public override void Draw(int upperMargin = 0)
        {
            QRCodeGenerator gen = new QRCodeGenerator();
            QRCodeData qrCodeData = gen.CreateQrCode(_data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qr = qrCode.GetGraphic(20, Consts.mainColor, BackColor, false);
            gen.Dispose(); qrCodeData.Dispose(); qrCode.Dispose();
            int qrSize = Consts.Millimeters(_size);
            Bitmap res = new Bitmap(Consts.RollWidth, qrSize + upperMargin);
            res.SetResolution(Consts.dpi, Consts.dpi);

            using (Graphics gr = Graphics.FromImage(res))
            {
                gr.FillRectangle(new SolidBrush(BackColor), 0, 0, res.Width, res.Height);
                gr.DrawImage(qr, res.Width / 2 - qrSize / 2, upperMargin, qrSize, qrSize);
                gr.Flush();
                gr.Dispose();
                Bitmap = res;
            }
        }

        public QR(string data, int size, int position)
        {
            Type = "QR";
            Position = position;
            base.GenInfoText(data);
            Data = data;
            Size = size;
        }
        public QR() { }
    }
}
