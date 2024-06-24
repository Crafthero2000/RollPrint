namespace RollPrint
{
    partial class SelectedFontControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            fontNameLabel = new ReaLTaiizor.Controls.MaterialLabel();
            fontInfoLabel = new ReaLTaiizor.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.text_fields_24dp;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(48, 48);
            materialCard1.TabIndex = 1;
            // 
            // fontNameLabel
            // 
            fontNameLabel.AutoEllipsis = true;
            fontNameLabel.AutoSize = true;
            fontNameLabel.Depth = 0;
            fontNameLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            fontNameLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            fontNameLabel.Location = new Point(79, 14);
            fontNameLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            fontNameLabel.Name = "fontNameLabel";
            fontNameLabel.Size = new Size(170, 24);
            fontNameLabel.TabIndex = 2;
            fontNameLabel.Text = "Название шрифта";
            // 
            // fontInfoLabel
            // 
            fontInfoLabel.AutoSize = true;
            fontInfoLabel.Depth = 0;
            fontInfoLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            fontInfoLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Body2;
            fontInfoLabel.Location = new Point(79, 38);
            fontInfoLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            fontInfoLabel.Name = "fontInfoLabel";
            fontInfoLabel.Size = new Size(99, 17);
            fontInfoLabel.TabIndex = 3;
            fontInfoLabel.Text = "Стиль | Размер";
            // 
            // SelectedFontControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(fontInfoLabel);
            Controls.Add(fontNameLabel);
            Controls.Add(materialCard1);
            Name = "SelectedFontControl";
            Size = new Size(409, 77);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel fontNameLabel;
        private ReaLTaiizor.Controls.MaterialLabel fontInfoLabel;
    }
}
