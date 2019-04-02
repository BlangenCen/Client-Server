using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        bool action = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始")
            {
                action = true;
                button1.Text = "停止";
                th = new Thread(RandomNumber);
                th.IsBackground = true;
                th.Name = "卢本伟牛逼！";
                th.Start();
            }
            else if (button1.Text == "停止")
            {
                action = false;
                button1.Text = "开始";
            }
        }

        void RandomNumber()
        {
            while (action)
            {
                Random r = new Random();
                label1.Text = r.Next(0, 1000).ToString();
                label2.Text = r.Next(0, 1000).ToString();
                label3.Text = r.Next(0, 1000).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null)
            {
                th.Abort();
            }
        }
    }
}
