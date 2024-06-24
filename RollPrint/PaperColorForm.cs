using ReaLTaiizor.Forms;
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
    public partial class PaperColorForm : MaterialForm
    {
        private string paperColor;
        public string PaperColor { get { return paperColor; } set { paperColor = value; materialComboBox1.SelectedItem = value; } }
        public PaperColorForm(string oldColor)
        {
            InitializeComponent();
            PaperColor = oldColor;
        }

        private void PaperColorForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            PaperColor = materialComboBox1.SelectedItem.ToString();
        }
    }
}
