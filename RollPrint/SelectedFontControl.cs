using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollPrint
{
    public partial class SelectedFontControl : UserControl
    {
        private string _fontName = "";
        private string _fontType = "";
        private float _fontSize;

        public delegate void FontDataHandler(object sender, EventArgs e);
        public event FontDataHandler? FontDataChanged;
        public string FontName { get { return _fontName; } set { _fontName = value; fontNameLabel.Text = _fontName; FontDataChanged?.Invoke(this, new EventArgs()); } }
        public string FontType { get { return _fontType; } set { if (value != "") { _fontType = value; fontInfoLabel.Text = $"{_fontType} | {_fontSize}pt"; FontDataChanged?.Invoke(this, new EventArgs()); } } }
        public float FontSize { get { return _fontSize; } set { if (value != 0) { _fontSize = value; fontInfoLabel.Text = $"{_fontType} | {_fontSize}pt"; FontDataChanged?.Invoke(this, new EventArgs()); } } }

        public SelectedFontControl()
        {
            InitializeComponent();
            
        }
    }
}
