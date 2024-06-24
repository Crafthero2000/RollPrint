using RollPrint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Bluetooth;

namespace RollPrint
{
    public partial class BluetoothStatusControl : UserControl
    {
        public enum Status
        { On, OffOrNotSupported }

        private static Status _status;

        public Status BluetoothStatus
        { get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    if (value == Status.On) { pictureBox1.Image = Resources.bluetooth_24dp; materialLabel1.Text = "BLUETOOTH ВКЛЮЧЕН"; }
                    else { pictureBox1.Image = Resources.bluetooth_disabled_24dp; materialLabel1.Text = "BLUETOOTH ВЫКЛЮЧЕН ИЛИ НЕ ПОДДЕРЖИВАЕТСЯ"; }
                }
            }
        }

        public BluetoothStatusControl()
        {
            InitializeComponent();
            BluetoothStatus = Status.OffOrNotSupported;
        }
    }
}
