using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace 客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(txtServer.Text);
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            try
            {
                socketSend.Connect(point);
            }
            catch
            {
                MessageBox.Show("服务器未打开！");
                return;
            }
            ShowMsg("连接成功！");

            Thread th = new Thread(Receive);
            th.IsBackground = true;
            th.Start();
        }

        private void ShowMsg(string v)
        {
            txtLog.AppendText(v + "\r\n");
        }

        private void Receive()
        {
            while (true)
            {
                byte[] b = new byte[5 * 1024 * 1024];
                int r = socketSend.Receive(b);
                if (r == 0)
                {
                    break;
                }
                //文本
                if (b[0] == 1)
                {
                    string s = Encoding.Default.GetString(b, 1, r - 1);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + "：" + s);
                }
                //文件
                else if (b[0] == 2)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "请选择要保存到的目录！o(∩_∩)o ";
                    sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
                    sfd.Filter = "文本文件|*.txt|所有文件|*。*";
                    //这里不加this会出错
                    sfd.ShowDialog(this);
                    if (sfd.FileName == "")
                    {
                        return;
                    }
                    using (FileStream fW = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fW.Write(b, 1, r - 1);
                    }
                    MessageBox.Show("保存成功！");
                }
                //窗口震动
                else if (b[0] == 3)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        this.Location = new Point(200, 500);
                        this.Location = new Point(300, 300);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] b = Encoding.Default.GetBytes(txtMsg.Text);
            socketSend.Send(b);
            txtMsg.Text = "";
        }
    }
}
