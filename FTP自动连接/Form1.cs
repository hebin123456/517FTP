using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP自动连接
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            string IP = getIP();
            if(IP == "0.0.0.0") IP_textBox.Text = Properties.Settings.Default.IP;
            else IP_textBox.Text = IP;
            username_textBox.Text = Properties.Settings.Default.username;
            password_textBox.Text = Properties.Settings.Default.password;
        }

        private void getIP_button_Click(object sender, EventArgs e)
        {
            IP_textBox.Text = getIP();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = IP_textBox.Text;
            Properties.Settings.Default.username = username_textBox.Text;
            Properties.Settings.Default.password = password_textBox.Text;
            Properties.Settings.Default.Save();

            System.Diagnostics.Process.Start("Explorer.exe", string.Format("ftp://{0}:{1}@{2}/", username_textBox.Text, password_textBox.Text, IP_textBox.Text));
        }

        private string getIP()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                //以字符串的形式返回数据
                string html = wc.DownloadString("http://ftp.hebin.me/");
                if (html == "Error") return "0.0.0.0";
                return html;
            }
            catch
            {
                return "0.0.0.0";
            }
        }
    }
}
