using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageToRollFramework;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RollPrint
{
    public partial class AddTextForm : MaterialForm
    {
        private TextLine textLine = new TextLine();

        public TextLine TextLine { get { return textLine; } }

        private ArrayList alignList = new ArrayList() { new { Type = Align.Center, DisplayName = "По центру" }, new { Type = Align.Left, DisplayName = "Слева" }, new { Type = Align.Right, DisplayName = "Справа" } };

        public AddTextForm(string text = "", Align align = Align.Center, Font font = null)
        {
            InitializeComponent();

            materialTextBoxEdit1.Text = text;
            materialComboBox1.DataSource = alignList;
            materialComboBox1.ValueMember = "Type";
            materialComboBox1.DisplayMember = "DisplayName";
            materialComboBox1.SelectedValue = align;

            if (font != null) genFontLabel(font);
            textLine.Font = font;
        }

        private void genFontLabel(Font font)
        {
            selectedFontControl1.FontName = font.Name;
            selectedFontControl1.FontSize = font.Size;
            selectedFontControl1.FontType = (font.Style == FontStyle.Regular ? "Обычный" : (font.Style == FontStyle.Bold ? "Полужирный" : (font.Style == FontStyle.Italic ? "Курсив" : (font.Style == FontStyle.Underline ? "Подчёркнутый" : (font.Style == FontStyle.Strikeout ? "Зачёркнутый" : (font.Style == (FontStyle.Bold | FontStyle.Italic) ? "Полужирный курсив" : (font.Style == (FontStyle.Underline | FontStyle.Bold) ? "Подчёркнутый полужирный" : (font.Style == (FontStyle.Strikeout | FontStyle.Bold) ? "Зачёркнутый полужирный" : (font.Style == (FontStyle.Underline | FontStyle.Bold | FontStyle.Italic) ? "Подчёркнутый полужирный курсив" : (font.Style == (FontStyle.Strikeout | FontStyle.Bold | FontStyle.Italic) ? "Зачёркнутый полужирный курсив" : (font.Style == (FontStyle.Underline | FontStyle.Italic) ? "Подчёркнутый курсив" : (font.Style == (FontStyle.Strikeout | FontStyle.Italic) ? "Зачёркнутый курсив" : (font.Style == (FontStyle.Underline | FontStyle.Strikeout) ? "Подчёркнутый зачёркнутый" : (font.Style == (FontStyle.Underline | FontStyle.Strikeout | FontStyle.Italic) ? "Подчёркнутый зачёркнутый курсив" : (font.Style == (FontStyle.Bold | FontStyle.Italic) ? "Полужирный курсив" : (font.Style == (FontStyle.Underline | FontStyle.Strikeout | FontStyle.Bold) ? "Подчёркнутый зачёркнутый полужирный" : (font.Style == (FontStyle.Underline | FontStyle.Strikeout | FontStyle.Bold | FontStyle.Italic) ? "Подчёркнутый зачёркнутый полужирный курсив" : "")))))))))))))))));
        }

        private void selectFontButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult d = fd.ShowDialog();
            if (d == DialogResult.OK)
            {
                textLine.Font = fd.Font;
                genFontLabel(fd.Font);
            }
        }

        private void materialComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textLine.Align = (Align)materialComboBox1.SelectedValue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (materialTextBoxEdit1.Text != String.Empty & selectedFontControl1.FontName != "Не выбрано") materialButton2.Enabled = true;
            else if (materialTextBoxEdit1.Text != String.Empty) materialButton2.Enabled = false;
            else if (selectedFontControl1.FontName != "Не выбрано") materialButton2.Enabled = false;

            textLine.Text = materialTextBoxEdit1.Text;
        }

        private void selectedFontLabel_TextChanged(object sender, EventArgs e)
        {
            if (materialTextBoxEdit1.Text != String.Empty & selectedFontControl1.FontName != "Не выбрано") materialButton2.Enabled = true;
            else if (materialTextBoxEdit1.Text != String.Empty) materialButton2.Enabled = false;
            else if (selectedFontControl1.FontName != "Не выбрано") materialButton2.Enabled = false;
        }
    }
}
