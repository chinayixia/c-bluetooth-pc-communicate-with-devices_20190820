using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace RubikSolverV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Get all port list for selection
            //获得所有的端口列表，并显示在列表内
            PortList.Items.Clear();
            string[] Ports = SerialPort.GetPortNames();

            for (int i = 0; i < Ports.Length; i++)
            {
                string s = Ports[i].ToUpper();
                Regex reg = new Regex("[^COM\\d]", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                s = reg.Replace(s, "");

                PortList.Items.Add(s);
            }
            if (Ports.Length > 1) PortList.SelectedIndex = 1;
        }

        #region Bluetooth related codes

        //Create a serial port for bluetooth
        SerialPort BluetoothConnection = new SerialPort();

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!BluetoothConnection.IsOpen)
            {
                //Start
                Status = "正在连接蓝牙设备";
                BluetoothConnection = new SerialPort();
                ConnectButton.Enabled = false;
                BluetoothConnection.PortName = PortList.SelectedItem.ToString();
                BluetoothConnection.Open();
                BluetoothConnection.ReadTimeout = 10000;
                BluetoothConnection.DataReceived += new SerialDataReceivedEventHandler(BlueToothDataReceived);
                Status = "蓝牙连接成功";
            }
        }

        private void BlueToothDataReceived(object o, SerialDataReceivedEventArgs e)
        {
            //int length = BluetoothConnection.ReadByte();
            Thread.Sleep(1000);
            int length = 13;
            BlueToothReceivedData = DateTime.Now.ToLongTimeString() + "\r\n";
            BlueToothReceivedData += "收到字节数：" + length + "\r\n";

            byte[] data = new byte[length];
            BluetoothConnection.Read(data,0,length);
            for (int i = 0; i < length; i++)
            {
                BlueToothReceivedData += string.Format("data[{0}] = {1}\r\n", i, data[i]);
            }
            //receive close message
            if (length == 3 && data[0] == 255 && data[1] == 255 && data[2] == 255)
            {
                //Stop
                Status = "正在断开蓝牙设备";
                BluetoothConnection.Close();
                BluetoothConnection.Dispose();
                BluetoothConnection = null;
                ConnectButton.Enabled = true;
                Status = "蓝牙断开成功";
            }
        }

        private void BlueToothDataSend(byte[] data)
        {
            //int length = data.Length;
            //byte[] readData = new byte[length + 2];
            //readData[0] = (byte)(length % 255);
            //readData[1] = (byte)(length / 255);
            //for (int i = 0; i < length; i++)
            //{
            //    readData[i + 2] = data[i];
            //}
            //BluetoothConnection.Write(readData, 0, length + 2);
            BluetoothConnection.Write(data, 0, 1);
            //Status = "发送数据字节数：" + length;
        }
        #endregion


        private string Status, BlueToothReceivedData;
        private void MonitorTimer_Tick(object sender, EventArgs e)
        {
            StatusMessage.Text = Status;
            BlueToothMessage.Text = BlueToothReceivedData;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            byte n;
            byte.TryParse(SendMessage.Text, out n);

            BlueToothDataSend(new byte[] { n });
        }
    }
}

