using ImageToRollFramework;

namespace RollPrint
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            addSeparatorButton = new ReaLTaiizor.Controls.MaterialButton();
            addTableButton = new ReaLTaiizor.Controls.MaterialButton();
            addIconButton = new ReaLTaiizor.Controls.MaterialButton();
            addQRButton = new ReaLTaiizor.Controls.MaterialButton();
            addTextButton = new ReaLTaiizor.Controls.MaterialButton();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialContextMenuStrip1 = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            itemPropertiesButton = new ReaLTaiizor.Controls.MaterialToolStripMenuItem();
            deleteItemButton = new ReaLTaiizor.Controls.MaterialToolStripMenuItem();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            panel1 = new Panel();
            canvas = new Canvas();
            materialDivider2 = new ReaLTaiizor.Controls.MaterialDivider();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialDivider3 = new ReaLTaiizor.Controls.MaterialDivider();
            materialCard4 = new ReaLTaiizor.Controls.MaterialCard();
            canvasItemsBox = new ReaLTaiizor.Controls.MaterialListBox();
            materialDivider4 = new ReaLTaiizor.Controls.MaterialDivider();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            clearCanvasButton = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            changePaperColorButton = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            sendToDeviceButton = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            saveButton = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            bluetoothServiceBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            bluetoothStatusControl1 = new BluetoothStatusControl();
            sendToDeviceBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            materialCard1.SuspendLayout();
            materialContextMenuStrip1.SuspendLayout();
            materialCard2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            materialCard4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 100);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(0, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(200, 100);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(918, 458);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "TEST";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += MaterialButton1_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(addSeparatorButton);
            materialCard1.Controls.Add(addTableButton);
            materialCard1.Controls.Add(addIconButton);
            materialCard1.Controls.Add(addQRButton);
            materialCard1.Controls.Add(addTextButton);
            materialCard1.Controls.Add(materialDivider1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 73);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(200, 272);
            materialCard1.TabIndex = 2;
            // 
            // addSeparatorButton
            // 
            addSeparatorButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addSeparatorButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addSeparatorButton.Depth = 0;
            addSeparatorButton.HighEmphasis = true;
            addSeparatorButton.Icon = Properties.Resources.line_style_24dp;
            addSeparatorButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addSeparatorButton.Location = new Point(18, 224);
            addSeparatorButton.Margin = new Padding(4, 6, 4, 6);
            addSeparatorButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addSeparatorButton.Name = "addSeparatorButton";
            addSeparatorButton.NoAccentTextColor = Color.Empty;
            addSeparatorButton.Size = new Size(155, 36);
            addSeparatorButton.TabIndex = 6;
            addSeparatorButton.Text = "Разделитель";
            addSeparatorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addSeparatorButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addSeparatorButton.UseAccentColor = false;
            addSeparatorButton.UseVisualStyleBackColor = true;
            addSeparatorButton.Click += AddSeparatorButton_Click;
            // 
            // addTableButton
            // 
            addTableButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addTableButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addTableButton.Depth = 0;
            addTableButton.HighEmphasis = true;
            addTableButton.Icon = Properties.Resources.table_chart_24dp;
            addTableButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addTableButton.Location = new Point(18, 179);
            addTableButton.Margin = new Padding(4, 6, 4, 6);
            addTableButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addTableButton.Name = "addTableButton";
            addTableButton.NoAccentTextColor = Color.Empty;
            addTableButton.Size = new Size(119, 36);
            addTableButton.TabIndex = 5;
            addTableButton.Text = "Таблица";
            addTableButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addTableButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addTableButton.UseAccentColor = false;
            addTableButton.UseVisualStyleBackColor = true;
            // 
            // addIconButton
            // 
            addIconButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addIconButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addIconButton.Depth = 0;
            addIconButton.HighEmphasis = true;
            addIconButton.Icon = Properties.Resources.image_24dp;
            addIconButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addIconButton.Location = new Point(18, 134);
            addIconButton.Margin = new Padding(4, 6, 4, 6);
            addIconButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addIconButton.Name = "addIconButton";
            addIconButton.NoAccentTextColor = Color.Empty;
            addIconButton.Size = new Size(127, 36);
            addIconButton.TabIndex = 4;
            addIconButton.Text = "Картинка";
            addIconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addIconButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addIconButton.UseAccentColor = false;
            addIconButton.UseVisualStyleBackColor = true;
            // 
            // addQRButton
            // 
            addQRButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addQRButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addQRButton.Depth = 0;
            addQRButton.HighEmphasis = true;
            addQRButton.Icon = Properties.Resources.qr_code_2_24dp;
            addQRButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addQRButton.Location = new Point(18, 90);
            addQRButton.Margin = new Padding(4, 6, 4, 6);
            addQRButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addQRButton.Name = "addQRButton";
            addQRButton.NoAccentTextColor = Color.Empty;
            addQRButton.Size = new Size(104, 36);
            addQRButton.TabIndex = 3;
            addQRButton.Text = "QR-код";
            addQRButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addQRButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addQRButton.UseAccentColor = false;
            addQRButton.UseVisualStyleBackColor = true;
            // 
            // addTextButton
            // 
            addTextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addTextButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addTextButton.Depth = 0;
            addTextButton.HighEmphasis = true;
            addTextButton.Icon = Properties.Resources.text_fields_24dp;
            addTextButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addTextButton.Location = new Point(18, 45);
            addTextButton.Margin = new Padding(4, 6, 4, 6);
            addTextButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addTextButton.Name = "addTextButton";
            addTextButton.NoAccentTextColor = Color.Empty;
            addTextButton.Size = new Size(95, 36);
            addTextButton.TabIndex = 2;
            addTextButton.Text = "Текст";
            addTextButton.TextAlign = ContentAlignment.MiddleRight;
            addTextButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addTextButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addTextButton.UseAccentColor = false;
            addTextButton.UseVisualStyleBackColor = true;
            addTextButton.Click += AddTextButton_Click;
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(0, 34);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(200, 3);
            materialDivider1.TabIndex = 1;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            materialLabel1.Location = new Point(17, 8);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(166, 18);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Элементы";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.Items.AddRange(new ToolStripItem[] { itemPropertiesButton, deleteItemButton });
            materialContextMenuStrip1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.Size = new Size(181, 90);
            materialContextMenuStrip1.Opening += materialContextMenuStrip1_Opening;
            // 
            // itemPropertiesButton
            // 
            itemPropertiesButton.AutoSize = false;
            itemPropertiesButton.Name = "itemPropertiesButton";
            itemPropertiesButton.Size = new Size(128, 32);
            itemPropertiesButton.Text = "Свойства";
            itemPropertiesButton.Click += itemPropertiesButton_Click;
            // 
            // deleteItemButton
            // 
            deleteItemButton.AutoSize = false;
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(128, 32);
            deleteItemButton.Text = "Удалить";
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel1);
            materialCard2.Controls.Add(materialDivider2);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(245, 73);
            materialCard2.Margin = new Padding(14, 13, 14, 13);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 13, 14, 13);
            materialCard2.Size = new Size(559, 522);
            materialCard2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(canvas);
            panel1.Location = new Point(17, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 452);
            panel1.TabIndex = 4;
            // 
            // canvas
            // 
            canvas.Image = null;
            canvas.Location = new Point(12, 12);
            canvas.Name = "canvas";
            canvas.Size = new Size(300, 50);
            canvas.SizeMode = PictureBoxSizeMode.AutoSize;
            canvas.TabIndex = 3;
            canvas.TabStop = false;
            canvas.OnImageChange += canvas_OnImageChange;
            // 
            // materialDivider2
            // 
            materialDivider2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(0, 34);
            materialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(559, 3);
            materialDivider2.TabIndex = 2;
            materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            materialLabel2.Location = new Point(17, 8);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(525, 18);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "Предпросмотр";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(-10, 611);
            materialDivider3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(1100, 3);
            materialDivider3.TabIndex = 5;
            materialDivider3.Text = "materialDivider3";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(canvasItemsBox);
            materialCard4.Controls.Add(materialDivider4);
            materialCard4.Controls.Add(materialLabel3);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(832, 73);
            materialCard4.Margin = new Padding(14, 13, 14, 13);
            materialCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14, 13, 14, 13);
            materialCard4.Size = new Size(237, 295);
            materialCard4.TabIndex = 6;
            // 
            // canvasItemsBox
            // 
            canvasItemsBox.BackColor = Color.White;
            canvasItemsBox.BorderColor = Color.LightGray;
            canvasItemsBox.ContextMenuStrip = materialContextMenuStrip1;
            canvasItemsBox.Depth = 0;
            canvasItemsBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            canvasItemsBox.Location = new Point(0, 43);
            canvasItemsBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            canvasItemsBox.MultiSelect = true;
            canvasItemsBox.Name = "canvasItemsBox";
            canvasItemsBox.SelectedIndex = -1;
            canvasItemsBox.SelectedItem = null;
            canvasItemsBox.ShowBorder = false;
            canvasItemsBox.ShowScrollBar = true;
            canvasItemsBox.Size = new Size(237, 236);
            canvasItemsBox.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            canvasItemsBox.TabIndex = 4;
            canvasItemsBox.Leave += canvasItemsBox_Leave;
            // 
            // materialDivider4
            // 
            materialDivider4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialDivider4.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider4.Depth = 0;
            materialDivider4.Location = new Point(0, 34);
            materialDivider4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new Size(237, 3);
            materialDivider4.TabIndex = 3;
            materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            materialLabel3.Location = new Point(17, 8);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(203, 18);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Структура";
            materialLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearCanvasButton
            // 
            clearCanvasButton.AnimateShowHideButton = true;
            clearCanvasButton.Depth = 0;
            clearCanvasButton.Enabled = false;
            clearCanvasButton.Icon = Properties.Resources.delete_forever_24dp;
            clearCanvasButton.Location = new Point(1013, 620);
            clearCanvasButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            clearCanvasButton.Name = "clearCanvasButton";
            clearCanvasButton.Size = new Size(56, 56);
            clearCanvasButton.TabIndex = 7;
            clearCanvasButton.Text = "materialFloatingActionButton1";
            clearCanvasButton.UseVisualStyleBackColor = true;
            clearCanvasButton.Click += ClearCanvasButton_Click;
            // 
            // changePaperColorButton
            // 
            changePaperColorButton.Depth = 0;
            changePaperColorButton.Icon = Properties.Resources.palette_24dp;
            changePaperColorButton.Location = new Point(951, 620);
            changePaperColorButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            changePaperColorButton.Name = "changePaperColorButton";
            changePaperColorButton.Size = new Size(56, 56);
            changePaperColorButton.TabIndex = 8;
            changePaperColorButton.Text = "materialFloatingActionButton2";
            changePaperColorButton.UseVisualStyleBackColor = true;
            changePaperColorButton.Click += ChangePaperColorButton_Click;
            // 
            // sendToDeviceButton
            // 
            sendToDeviceButton.Depth = 0;
            sendToDeviceButton.Enabled = false;
            sendToDeviceButton.Icon = Properties.Resources.send_to_mobile_24dp;
            sendToDeviceButton.Location = new Point(889, 620);
            sendToDeviceButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            sendToDeviceButton.Name = "sendToDeviceButton";
            sendToDeviceButton.Size = new Size(56, 56);
            sendToDeviceButton.TabIndex = 9;
            sendToDeviceButton.Text = "materialFloatingActionButton3";
            sendToDeviceButton.UseVisualStyleBackColor = true;
            sendToDeviceButton.Click += sendToDeviceButton_Click;
            // 
            // saveButton
            // 
            saveButton.AnimateShowHideButton = true;
            saveButton.Depth = 0;
            saveButton.Enabled = false;
            saveButton.Icon = Properties.Resources.save_24dp;
            saveButton.Location = new Point(827, 620);
            saveButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(56, 56);
            saveButton.TabIndex = 10;
            saveButton.Text = "materialFloatingActionButton4";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // bluetoothServiceBackgroundWorker
            // 
            bluetoothServiceBackgroundWorker.DoWork += BluetoothServiceBackgroundWorker_DoWork;
            // 
            // bluetoothStatusControl1
            // 
            bluetoothStatusControl1.BluetoothStatus = BluetoothStatusControl.Status.OffOrNotSupported;
            bluetoothStatusControl1.Location = new Point(35, 620);
            bluetoothStatusControl1.Name = "bluetoothStatusControl1";
            bluetoothStatusControl1.Size = new Size(440, 56);
            bluetoothStatusControl1.TabIndex = 12;
            // 
            // sendToDeviceBackgroundWorker
            // 
            sendToDeviceBackgroundWorker.DoWork += sendToDeviceBackgroundWorker_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 681);
            Controls.Add(bluetoothStatusControl1);
            Controls.Add(saveButton);
            Controls.Add(sendToDeviceButton);
            Controls.Add(changePaperColorButton);
            Controls.Add(clearCanvasButton);
            Controls.Add(materialCard4);
            Controls.Add(materialDivider3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(materialButton1);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.IndianRed;
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(1084, 681);
            MinimumSize = new Size(1084, 681);
            Name = "Form1";
            Padding = new Padding(3, 60, 1, 2);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Печать на термобумаге";
            TransparencyKey = Color.Fuchsia;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialContextMenuStrip1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            materialCard4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider2;
        private ReaLTaiizor.Controls.MaterialButton addTableButton;
        private ReaLTaiizor.Controls.MaterialButton addIconButton;
        private ReaLTaiizor.Controls.MaterialButton addQRButton;
        private ReaLTaiizor.Controls.MaterialButton addTextButton;
        private ReaLTaiizor.Controls.MaterialButton addSeparatorButton;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider3;
        private ReaLTaiizor.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider4;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton clearCanvasButton;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton changePaperColorButton;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton sendToDeviceButton;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton saveButton;
        private System.ComponentModel.BackgroundWorker bluetoothServiceBackgroundWorker;
        private Canvas canvas;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialListBox canvasItemsBox;
        private BluetoothStatusControl bluetoothStatusControl1;
        private System.ComponentModel.BackgroundWorker sendToDeviceBackgroundWorker;
        private ReaLTaiizor.Controls.MaterialToolStripMenuItem itemPropertiesButton;
        private ReaLTaiizor.Controls.MaterialToolStripMenuItem deleteItemButton;
    }
}
