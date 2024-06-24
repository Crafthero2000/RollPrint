using System.Collections;
using System.Drawing;

namespace RollPrintFramework
{
    internal class Consts
    {
        public static GraphicsUnit gU = GraphicsUnit.Pixel;
        public static Font f = new Font("Courier New", 12f, FontStyle.Bold);
        public const int dpi = 200;
        public static Color mainColor = Color.Black;
        public static SolidBrush mainBrush = new SolidBrush(mainColor);
        public static Pen mainPen = new Pen(mainColor, 3f);
        public static int Millimeters(int millimeters)
        {
            return (int)(dpi * millimeters * 0.03937);
        }
        public static int RollWidth = Millimeters(57);
    }
}
