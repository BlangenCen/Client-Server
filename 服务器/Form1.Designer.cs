namespace 服务器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnZD = new System.Windows.Forms.Button();
            this.btnOF = new System.Windows.Forms.Button();
            this.btnSF = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(272, 24);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(457, 389);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 33);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnZD
            // 
            this.btnZD.Location = new System.Drawing.Point(367, 389);
            this.btnZD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZD.Name = "btnZD";
            this.btnZD.Size = new System.Drawing.Size(68, 33);
            this.btnZD.TabIndex = 2;
            this.btnZD.Text = "窗口震动";
            this.btnZD.UseVisualStyleBackColor = true;
            this.btnZD.Click += new System.EventHandler(this.btnZD_Click);
            // 
            // btnOF
            // 
            this.btnOF.Location = new System.Drawing.Point(554, 347);
            this.btnOF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOF.Name = "btnOF";
            this.btnOF.Size = new System.Drawing.Size(63, 33);
            this.btnOF.TabIndex = 3;
            this.btnOF.Text = "打开文件";
            this.btnOF.UseVisualStyleBackColor = true;
            this.btnOF.Click += new System.EventHandler(this.btnOF_Click);
            // 
            // btnSF
            // 
            this.btnSF.Location = new System.Drawing.Point(630, 347);
            this.btnSF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(61, 33);
            this.btnSF.TabIndex = 4;
            this.btnSF.Text = "发送文件";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSF_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(28, 32);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(119, 21);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "172.18.38.99";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(170, 32);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 21);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "50000";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(28, 75);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(523, 146);
            this.txtLog.TabIndex = 7;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(28, 241);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(523, 91);
            this.txtMsg.TabIndex = 8;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(28, 355);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(515, 21);
            this.txtFile.TabIndex = 9;
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(379, 32);
            this.cboUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(164, 20);
            this.cboUsers.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 431);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.btnOF);
            this.Controls.Add(this.btnZD);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "服务端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnZD;
        private System.Windows.Forms.Button btnOF;
        private System.Windows.Forms.Button btnSF;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ComboBox cboUsers;
    }
}

