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

namespace 服务器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //用于储存客户端终结点信息
        Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                socketWatch.Bind(point);
                ShowMsg("监听成功！");
                this.Show();
                socketWatch.Listen(10);

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
                btnStart.Enabled = false;
            }
            catch { }
        }

        private void ShowMsg(string s)
        {
            txtLog.AppendText(s + "\r\n");
        }

        Socket socketSend;
        /// <summary>
        /// 等待客户端连接，并创建一个负责通信的socket
        /// </summary>
        /// <param name="o"></param>
        private void Listen(object o)
        {
            while (true)
            {
                socketSend = (o as Socket).Accept();
                string s = socketSend.RemoteEndPoint.ToString();
                dic.Add(s, socketSend);
                cboUsers.Items.Add(s);
                ShowMsg(socketSend.RemoteEndPoint.ToString() + "：连接成功");
                //每连进一个客户端，就新建一个线程接受信息
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 服务器接受客户端消息
        /// </summary>
        private void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] b = new byte[5 * 1024 * 1024];
                    int r = socketSend.Receive(b);
                    if (r == 0)
                    {
                        break;
                    }
                    string s = Encoding.Default.GetString(b, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + "：" + s);
                }
                catch { }
            }
        }
        /// <summary>
        /// 发送文消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            List<byte> bList = new List<byte>();
            byte[] b = Encoding.Default.GetBytes((txtFile.Text));
            //文本消息bNew[0]标记1
            bList.Add(1);
            bList.AddRange(b);
            byte[] bNew = bList.ToArray();
            if (cboUsers.Text == "")
            {
                //当没有选择下拉框时，下拉框为空
                MessageBox.Show("未选择客户端！");
                return;
            }
            else
            {
                dic[cboUsers.SelectedItem.ToString()].Send(bNew);
            }
            txtFile.Text = "";
        }

        private void btnOF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择你需要发送的文件o(︶︿︶)o ";
            ofd.Filter = "文本文件|*.txt|所有文件|*。*";
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                return;
            }
            txtFile.Text = ofd.FileName;
        }

        private void btnSF_Click(object sender, EventArgs e)
        {
            using (FileStream fR = new FileStream(txtFile.Text, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[5 * 1024 * 1024];
                int r = fR.Read(b, 0, b.Length);
                List<byte> bList = new List<byte>();
                //文件消息bNew[0]标记2
                bList.Add(2);
                bList.AddRange(b);
                byte[] bNew = bList.ToArray();
                if (cboUsers.Text == "")
                {
                    //当没有选择下拉框时，下拉框为空
                    //socketSend.Send(bNew);
                    MessageBox.Show("未选择客户端！");
                    return;
                }
                else
                {
                    dic[cboUsers.SelectedItem.ToString()].Send(bNew, 0, r + 1 , SocketFlags.None);
                }
            }
        }
        /// <summary>
        /// 窗口震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZD_Click(object sender, EventArgs e)
        {
            //文本消息bNew[0]标记3
            byte[] bNew = new byte[1];
            bNew[0] = 3;
            if (cboUsers.Text == "")
            {
                //当没有选择下拉框时，下拉框为空
                //socketSend.Send(bNew);
                MessageBox.Show("未选择客户端！");
                return;
            }
            else
            {
                dic[cboUsers.SelectedItem.ToString()].Send(bNew);
            }
        }
    }
}
