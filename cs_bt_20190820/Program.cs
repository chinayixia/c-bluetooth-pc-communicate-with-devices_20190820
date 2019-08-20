using System;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
// [注意1]：要添加如下三个命名空间
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace cs_bt_20190820
{
    class Program
    {
        static void Main(string[] args)
        {
            BluetoothRadio bluetoothRadio = BluetoothRadio.PrimaryRadio;
            if (bluetoothRadio == null)
            {
                Console.WriteLine("没有找到本机蓝牙设备!");
                Console.ReadLine();
            }
            else
            {
                Program p = new Program();
                p.localAdapterInfo(bluetoothRadio);
                p.openDoor();
            }
        }

        /**
         * 连接目标蓝牙设备发送开门指令
         * **/
        private void openDoor()
        {
            BluetoothClient cli = new BluetoothClient();
            BluetoothAddress addr = null;
            BluetoothEndPoint ep = null;
            try
            {
                // [注意2]：要注意MAC地址中字节的对应关系，直接来看顺序是相反的，例如
                // 如下对应的MAC地址为——12:34:56:78:9a:bc
                addr = new BluetoothAddress(new byte[] { 0xbc, 0x9a, 0x78, 0x56, 0x34, 0x12 });
                ep = new BluetoothEndPoint(addr, BluetoothService.SerialPort);
                cli.Connect(ep); // 连接蓝牙
                if (cli.Connected)
                {
                    Stream peerStream = cli.GetStream();
                    peerStream.WriteByte(0xBB); // 发送开门指令
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
            finally
            {
                if (cli != null)
                {
                    // [注意3]：要延迟一定时间(例如1000毫秒)
                    //避免因连接后又迅速断开而导致蓝牙进入异常(傻逼)状态
                    Thread.Sleep(1000);
                    cli.Close();
                }
            }
        }

        /**
         * 
         * 显示本地蓝牙的信息
         * 
         * **/
        private void localAdapterInfo(BluetoothRadio bluetoothRadio)
        {
            Console.WriteLine("ClassOfDevice: " + bluetoothRadio.ClassOfDevice);
            Console.WriteLine("HardwareStatus: " + bluetoothRadio.HardwareStatus);
            Console.WriteLine("HciRevision: " + bluetoothRadio.HciRevision);
            Console.WriteLine("HciVersion: " + bluetoothRadio.HciVersion);
            Console.WriteLine("LmpSubversion: " + bluetoothRadio.LmpSubversion);
            Console.WriteLine("LmpVersion: " + bluetoothRadio.LmpVersion);
            Console.WriteLine("LocalAddress: " + bluetoothRadio.LocalAddress);
            Console.WriteLine("Manufacturer: " + bluetoothRadio.Manufacturer);
            Console.WriteLine("Mode: " + bluetoothRadio.Mode);
            Console.WriteLine("Name: " + bluetoothRadio.Name);
            Console.WriteLine("Remote:" + bluetoothRadio.Remote);
            Console.WriteLine("SoftwareManufacturer: " + bluetoothRadio.SoftwareManufacturer);
            Console.WriteLine("StackFactory: " + bluetoothRadio.StackFactory);
            Console.ReadLine();

        }
    }
}
