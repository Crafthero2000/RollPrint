using ImageToRollFramework;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Collections.Specialized;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;
namespace RollPrint
{
    public partial class Form1 : MaterialForm
    {
        //private BluetoothClient bluetoothClient = new BluetoothClient();
        ImageRollHandler imageHandler;

        MaterialSkinManager skinManager;

        public Form1()
        {
            InitializeComponent();
            bluetoothServiceBackgroundWorker.RunWorkerAsync();
            skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.BlueGrey500, MaterialPrimary.BlueGrey700, MaterialPrimary.BlueGrey100, MaterialAccent.Blue700, MaterialTextShade.LIGHT);

            imageHandler = new ImageRollHandler(canvas);
            imageHandler.Items.CollectionChanged += CanvasItems_Changed;
            imageHandler.GenerateFinalImage();
        }

        private void CanvasItems_Changed(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    if (e.NewItems?[0] is CanvasItem newItem)
                    {
                        imageHandler.GenerateFinalImage();
                        canvasItemsBox.AddItem(new ReaLTaiizor.Child.Material.MaterialListBoxItem(newItem.HeaderText, newItem.DescriptionText));

                        saveButton.Enabled = true;
                        if (bluetoothStatusControl1.BluetoothStatus == BluetoothStatusControl.Status.On) sendToDeviceButton.Enabled = true;
                        clearCanvasButton.Enabled = true;
                        new MaterialSnackBar("Готово", 500).Show(this);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    if (e.OldItems?[0] is CanvasItem oldItem)
                    {
                        if (imageHandler.Items.Count == 0)
                        {
                            saveButton.Enabled = false;
                            sendToDeviceButton.Enabled = false;
                            clearCanvasButton.Enabled = false;
                        }
                        imageHandler.GenerateFinalImage();
                        for (int i = 0; i < imageHandler.Items.Count; i++)
                        {
                            imageHandler.Items[i].Position = i + 1;
                            imageHandler.Items[i].GenInfoText(imageHandler.Items[i].DescriptionText); //= Regex.Replace(imageHandler.Items[i].DisplayName, @"(^\d*)", imageHandler.Items[i].Position.ToString());
                            canvasItemsBox.Items[i].Text = imageHandler.Items[i].HeaderText; canvasItemsBox.Items[i].SecondaryText = imageHandler.Items[i].DescriptionText;
                        }
                        new MaterialSnackBar("Готово", 500).Show(this);
                    }
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    if ((e.NewItems?[0] is CanvasItem replacingItem) &&
                        (e.OldItems?[0] is CanvasItem replacedItem))
                    {
                        imageHandler.GenerateFinalImage();
                        canvasItemsBox.Items[replacedItem.Position - 1].Text = replacingItem.HeaderText; canvasItemsBox.Items[replacedItem.Position - 1].SecondaryText = replacingItem.DescriptionText;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    saveButton.Enabled = false;
                    sendToDeviceButton.Enabled = false;
                    clearCanvasButton.Enabled = false;
                    imageHandler.GenerateFinalImage();
                    canvasItemsBox.Items.Clear();
                    break;
            }
        }

        private void canvas_OnImageChange(object sender, EventArgs e)
        {
            canvas.Location = new Point(panel1.Width / 2 - canvas.Image.Width / 2, 50);
        }

        private void ChangePaperColorByText(string color)
        {
            switch (color)
            {
                case "Белый":
                    imageHandler.PaperColor = Color.White;
                    break;
                case "Жёлтый":
                    imageHandler.PaperColor = Color.Yellow;
                    break;
                case "Розовый":
                    imageHandler.PaperColor = Color.Pink;
                    break;
                case "Синий":
                    imageHandler.PaperColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }

        private string GetColorNameByColor(Color color)
        {
            switch (color.Name)
            {
                case "White":
                    return "Белый";
                case "Pink":
                    return "Розовый";
                case "Blue":
                    return "Синий";
                case "Yellow":
                    return "Жёлтый";
                default: return "Неизвестный";
            }
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BluetoothRadio.IsSupported.ToString());
        }

        private void ChangePaperColorButton_Click(object sender, EventArgs e)
        {
            var f = new PaperColorForm(GetColorNameByColor(imageHandler.PaperColor));
            if (ShowForm(f) == DialogResult.OK) ChangePaperColorByText(f.PaperColor);
        }

        private DialogResult ShowForm(MaterialForm dialog)
        {
            Form f = new Form() { BackColor = Color.Black, Opacity = .5f, StartPosition = FormStartPosition.CenterParent, Size = this.Size, FormBorderStyle = FormBorderStyle.None, ShowInTaskbar = false };
            f.Show(this);
            f.Location = this.Location;
            skinManager.AddFormToManage(dialog);
            dialog.FormClosing += (sender, e) => { f.Close(); f.Dispose(); };

            var res = dialog.ShowDialog(this);
            dialog.Dispose();

            return res;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = $"Roll Print {DateTime.Now.ToString(@"yyyy_MM_dd HH_mm")}"; sf.Filter = "PNG (*.png)|*.png";
            DialogResult d = sf.ShowDialog();
            if (d == DialogResult.OK) { imageHandler.ImageToPrint.Save(sf.FileName); }
        }

        private void BluetoothServiceBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (bluetoothStatusControl1.BluetoothStatus != BluetoothStatusControl.Status.On && BluetoothRadio.IsSupported) { bluetoothStatusControl1.BluetoothStatus = BluetoothStatusControl.Status.On; }
                else if (bluetoothStatusControl1.BluetoothStatus == BluetoothStatusControl.Status.On && !BluetoothRadio.IsSupported) { bluetoothStatusControl1.BluetoothStatus = BluetoothStatusControl.Status.OffOrNotSupported; }
            }
        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            var f = new AddTextForm();
            DialogResult d = ShowForm(f);
            if (d == DialogResult.OK)
            {
                imageHandler.AddTextLine(f.TextLine.Text, f.TextLine.Align, f.TextLine.Font);
            }
        }

        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            imageHandler.Items.Clear();
            new MaterialSnackBar("Холст очищен").Show(this);
        }

        private void AddSeparatorButton_Click(object sender, EventArgs e)
        {
            imageHandler.AddSeparator();
            new MaterialSnackBar("Разделитель добавлен").Show(this);
        }

        private void sendToDeviceButton_Click(object sender, EventArgs e)
        {
            sendToDeviceBackgroundWorker.RunWorkerAsync();
        }

        private void sendToDeviceBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var devices = new BluetoothDeviceInfo[] { };
            BluetoothDeviceInfo myDevice = new BluetoothDeviceInfo(new BluetoothAddress(242772606683656));
            this.Invoke(new Action(() => new MaterialSnackBar("Отправляем файл...").Show(this)));
            var fileName = $"printImage_{DateTime.Now.ToString(@"dd_MM_yyyyTHH_mm")}.png";
            Uri uri = new Uri($"obex://{myDevice.DeviceAddress}/{fileName}");
            ObexWebRequest req = new ObexWebRequest(uri);
            using (Stream content = req.GetRequestStream())
            {
                imageHandler.ImageToPrint.Save(content, ImageFormat.Png);
                req.ContentLength = content.Length;
            }
            try
            {
                ObexWebResponse rsp = (ObexWebResponse)req.GetResponse();
                this.Invoke(new Action(() => this.Enabled = true));
                switch (rsp.StatusCode)
                {
                    case ObexStatusCode.OK | ObexStatusCode.Final:
                        this.Invoke(new Action(() => new MaterialSnackBar("Файл передан успешно").Show(this)));
                        break;
                    case ObexStatusCode.Forbidden | ObexStatusCode.Final:
                        this.Invoke(new Action(() => new MaterialSnackBar("Отказано в получении файла").Show(this)));
                        break;
                    default:
                        this.Invoke(new Action(() => new MaterialSnackBar("Неизвестный статус передачи файла").Show(this)));
                        break;
                }
                rsp.Dispose();
            }
            catch (WebException ex)
            {
                this.Invoke(new Action(() => new MaterialSnackBar("Не удалось передать файл").Show(this)));
                if (ex.InnerException is EndOfStreamException)
                {
                    this.Invoke(new Action(() => new MaterialDialog(this, "Ошибка Bluetooth", "При передаче файла отключился Bluetooth. Проверьте подключение к Bluetooth на устройстве.").ShowDialog(this)));
                }
                else if (ex.InnerException is IOException)
                {
                    this.Invoke(new Action(() => new MaterialDialog(this, "Ошибка Bluetooth", "Передача файла прервалась по тайм-ауту. При необходимости повторите попытку и подтвердите получение файла на устройстве.").ShowDialog(this)));
                }
                else if (ex.InnerException is SocketException)
                {
                    this.Invoke(new Action(() => new MaterialDialog(this, "Ошибка Bluetooth", "Ошибка при подключении. Проверьте подключение к Bluetooth на передающем и принимающем устройстве.").ShowDialog(this)));
                }
                else
                {
                    this.Invoke(new Action(() => new MaterialDialog(this, "Ошибка Bluetooth", $"При передаче файла возникла ошибка сети:  {ex.Message} {ex.InnerException} . Проверьте подключение к Bluetooth на устройстве.").ShowDialog(this)));
                }
            }
        }

        private void materialContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (canvasItemsBox.SelectedItem != null)
            {
                materialContextMenuStrip1.Enabled = true;
            }
            else
            {
                materialContextMenuStrip1.Enabled = false;
            }
        }

        private void canvasItemsBox_Leave(object sender, EventArgs e)
        {
            canvasItemsBox.SelectedItem = null;
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            var itemToRemove = imageHandler.Items.Single(r => r.HeaderText == canvasItemsBox.SelectedItem.Text);
            canvasItemsBox.Items.Remove(canvasItemsBox.SelectedItem);
            canvasItemsBox.SelectedItem = null;
            imageHandler.Items.Remove(itemToRemove);
        }

        private void itemPropertiesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
