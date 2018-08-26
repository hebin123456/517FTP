using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP地址自动更新
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread thread;

        private void start_button_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(update));
            thread.Start();
            start_button.Enabled = false;
            stop_button.Enabled = true;
        }

        private string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        string IP = IpEntry.AddressList[i].ToString();
                        if (IP.IndexOf("10.10.") == 0) return IpEntry.AddressList[i].ToString();
                    }
                }
                return "0.0.0.0";
            }
            catch
            {
                return "0.0.0.0";
            }
        }

        private bool updateIP(string IP)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                //以字符串的形式返回数据
                string html = wc.DownloadString(string.Format("http://ftp.hebin.me/?changeIP={0}", IP));
                if (html == "Error") return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void update()
        {
            while (true)
            {
                //MessageBox.Show(GetLocalIP());
                string IP = GetLocalIP();
                updateIP(IP);
                //60s更新一次
                Thread.Sleep(60000);
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if(thread != null)
            {
                thread.Abort();
            }
            start_button.Enabled = true;
            stop_button.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible =false;
            this.Visible = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.Visible = false;
            }
        }
    }
}
