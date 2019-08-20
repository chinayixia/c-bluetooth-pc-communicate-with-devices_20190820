using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace wf_bluetooth_20190819
{
    public partial class Form1 : Form
    {

        //https://www.jb51.net/article/82144.htm



        BluetoothRadio radio = null;//蓝牙适配器 
        string sendFileName = null;//发送文件名 
        InTheHand.Net.BluetoothAddress sendAddress = null;//发送目的地址 
        ObexListener listener = null;//监听器 
        string recDir = null;//接受文件存放目录 
        Thread listenThread, sendThread;//发送/接收线程 

        public Form1()
        {
            InitializeComponent();
            radio = BluetoothRadio.PrimaryRadio;//获取当前PC的蓝牙适配器 
            CheckForIllegalCrossThreadCalls = false;//不检查跨线程调用 
            if (radio == null)//检查该电脑蓝牙是否可用 
            {
                MessageBox.Show("这个电脑蓝牙不可用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            recDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            labelRecDir.Text = recDir;
        }

        private void buttonSelectBluetooth_Click(object sender, EventArgs e)//选择远程蓝牙设备 
        {
            InTheHand.Windows.Forms.SelectBluetoothDeviceDialog dialog = new InTheHand.Windows.Forms.SelectBluetoothDeviceDialog();
            dialog.ShowRemembered = true;//显示已经记住的蓝牙设备 
            dialog.ShowAuthenticated = true;//显示认证过的蓝牙设备 
            dialog.ShowUnknown = true;//显示位置蓝牙设备 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sendAddress = dialog.SelectedDevice.DeviceAddress;//获取选择的远程蓝牙地址 
                labelAddress.Text = "地址:" + sendAddress.ToString() + "  设备名:" + dialog.SelectedDevice.DeviceName;
            }
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)//选择要发送的本地文件 
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sendFileName = dialog.FileName;//设置文件名 
                labelPath.Text = Path.GetFileName(sendFileName);
            }
        }


               
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            sendThread = new Thread(sendFile);//开启发送文件线程 
            sendThread.Start();
        }

        private void sendFile()//发送文件方法 
        {
            ObexWebRequest request = new ObexWebRequest(sendAddress, Path.GetFileName(sendFileName));//创建网络请求 
            WebResponse response = null;
            try
            {
                buttonSend.Enabled = false;
                request.ReadFile(sendFileName);//发送文件 
                labelInfo.Text = "开始发送!";
                response = request.GetResponse();//获取回应 
                labelInfo.Text = "发送完成!";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("发送失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelInfo.Text = "发送失败!";
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    buttonSend.Enabled = true;
                }
            }
        }





        private void receiveFile()//收文件方法 
        {
            ObexListenerContext context = null;
            ObexListenerRequest request = null;
            while (listener.IsListening)
            {
                context = listener.GetContext();//获取监听上下文 
                if (context == null)
                {
                    break;
                }
                request = context.Request;//获取请求 
                string uriString = Uri.UnescapeDataString(request.RawUrl);//将uri转换成字符串 
                string recFileName = recDir + uriString;
                request.WriteFile(recFileName);//接收文件 
                labelRecInfo.Text = "收到文件" + uriString.TrimStart(new char[] { '/' });
            }
        }

        private void ButtonListen_Click(object sender, EventArgs e)
        {
            if (listener == null || !listener.IsListening)
            {
                radio.Mode = RadioMode.Discoverable;//设置本地蓝牙可被检测 
                listener = new ObexListener(ObexTransport.Bluetooth);//创建监听 
                listener.Start();
                if (listener.IsListening)
                {
                    buttonListen.Text = "停止";
                    labelRecInfo.Text = "开始监听";
                    listenThread = new Thread(receiveFile);//开启监听线程 
                    listenThread.Start();
                }
            }
            else
            {
                listener.Stop();
                buttonListen.Text = "监听";
                labelRecInfo.Text = "停止监听";
            }
        }

        private void ButtonselectRecDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择蓝牙接收文件的存放路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                recDir = dialog.SelectedPath;
                labelRecDir.Text = recDir;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sendThread != null)
            {
                sendThread.Abort();
            }
            if (listenThread != null)
            {
                listenThread.Abort();
            }
            if (listener != null && listener.IsListening)
            {
                listener.Stop();
            }
        }
    }
}
