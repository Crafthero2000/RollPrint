using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using RollPrintFramework;

namespace RollPrintFramework
{
    public class Divider : CanvasItem
    {
        public override void Draw(int upperMargin = 0)
        {
            Pen p = new Pen(Consts.mainBrush);
            p.DashStyle = DashStyle.Dash;
            p.DashCap = DashCap.Triangle;
            p.DashOffset = 15;
            Bitmap res = new Bitmap(Consts.RollWidth, ((int)p.Width) + 20);
            res.SetResolution(Consts.dpi, Consts.dpi);

            using (Graphics g = Graphics.FromImage(res))
            {
                g.FillRectangle(new SolidBrush(BackColor), 0, 0, res.Width, res.Height);
                g.DrawLine(p, 0, res.Height / 2, res.Width, res.Height / 2);
                g.Flush();
                g.Dispose();
                p.Dispose();
                Bitmap = res;
            }
        }
        public Divider(int position) { Type = "Разделитель"; Position = position; base.GenInfoText("—"); }
    }
}
