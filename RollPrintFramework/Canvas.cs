using System;
using System.Drawing;
using System.Windows.Forms;

namespace RollPrintFramework
{
    public partial class Canvas : PictureBox
    {
        //Image changed delegate
        public delegate void ImageChanged(Object sender, EventArgs e);

        //event raised when image changed
        public event ImageChanged? OnImageChange;

        //overridden/hidden Image property with event hooked up
        public new Image Image
        {
            get { return base.Image; }
            set
            {
                base.Image = value;
                if (OnImageChange != null)
                {
                    OnImageChange(this, new EventArgs());
                }
            }
        }
    }
}