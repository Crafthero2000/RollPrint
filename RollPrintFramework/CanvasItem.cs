using System.Drawing;

namespace RollPrintFramework
{
    public class CanvasItem
    {
        public int Position;
        public string Type;
        public Bitmap Bitmap = new Bitmap(1, 1);
        public string HeaderText;
        public string DescriptionText;
        public Color BackColor;
        public virtual void Draw(int upperMargin = 0) { }
        public void GenInfoText(string otherData) { HeaderText = $"{Position} | {Type}"; DescriptionText = otherData; }
    }
}