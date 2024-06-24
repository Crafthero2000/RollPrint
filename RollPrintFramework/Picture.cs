using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using RollPrintFramework;

namespace RollPrintFramework
{
    public class Picture : CanvasItem
    {
        public string Origin { get; set; }

        public override void Draw(int upperMargin = 0)
        {
            Bitmap image = new Bitmap(Image.FromFile(Origin));
            image.SetResolution(Consts.dpi, Consts.dpi);
            int rW = image.Width > Consts.RollWidth ? image.Width / Consts.RollWidth : 1;
            Bitmap res = new Bitmap(Consts.RollWidth, image.Height / rW + upperMargin);
            res.SetResolution(Consts.dpi, Consts.dpi);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.FillRectangle(new SolidBrush(BackColor), 0, 0, res.Width, res.Height);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                if (rW > 1) g.DrawImage(image, 0, upperMargin, res.Width, res.Height - upperMargin);
                else g.DrawImage(image, res.Width / 2 - image.Width / 2, upperMargin);
                for (int row = 0; row < res.Width; row++) // Indicates row number
                {
                    for (int column = 0; column < res.Height; column++) // Indicate column number
                    {
                        var colorValue = res.GetPixel(row, column); // Get the color pixel
                        var averageValue = (colorValue.R + colorValue.G + colorValue.B) / 3; // get the average for black and white
                        res.SetPixel(row, column, colorValue.A == 255 ? (colorValue.ToArgb() == BackColor.ToArgb() || colorValue.ToArgb() == Color.White.ToArgb() ? BackColor : Color.FromArgb(255, averageValue, averageValue, averageValue)) : BackColor); // Set the value to new pixel
                    }
                }
                g.Flush(); g.Dispose();
                Bitmap = res;
            }
        }

        public Picture(string origin, int position)
        {
            Type = "Картинка";
            Origin = origin; Position = position;
            base.GenInfoText(origin);
        }

        public Picture() { }
    }
}
