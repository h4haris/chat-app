
namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.lblClientIP = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtChatBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxServer.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.btnServerStart);
            this.groupBoxServer.Controls.Add(this.txtServerPort);
            this.groupBoxServer.Controls.Add(this.lblServerPort);
            this.groupBoxServer.Controls.Add(this.txtServerIP);
            this.groupBoxServer.Controls.Add(this.lblServerIP);
            this.groupBoxServer.Location = new System.Drawing.Point(47, 40);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(566, 100);
            this.groupBoxServer.TabIndex = 0;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "SERVER";
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(446, 28);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(94, 38);
            this.btnServerStart.TabIndex = 4;
            this.btnServerStart.Text = "START";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(303, 36);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(113, 22);
            this.txtServerPort.TabIndex = 3;
            this.txtServerPort.Text = "13000";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(250, 39);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(47, 17);
            this.lblServerPort.TabIndex = 2;
            this.lblServerPort.Text = "PORT";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(81, 36);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(129, 22);
            this.txtServerIP.TabIndex = 1;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(55, 39);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(20, 17);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "IP";
            this.lblServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.btnClientConnect);
            this.groupBoxClient.Controls.Add(this.txtClientPort);
            this.groupBoxClient.Controls.Add(this.lblClientPort);
            this.groupBoxClient.Controls.Add(this.txtClientIP);
            this.groupBoxClient.Controls.Add(this.lblClientIP);
            this.groupBoxClient.Location = new System.Drawing.Point(47, 157);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(566, 100);
            this.groupBoxClient.TabIndex = 5;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "CLIENT";
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.Location = new System.Drawing.Point(446, 28);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(94, 38);
            this.btnClientConnect.TabIndex = 4;
            this.btnClientConnect.Text = "CONNECT";
            this.btnClientConnect.UseVisualStyleBackColor = true;
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(303, 36);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(113, 22);
            this.txtClientPort.TabIndex = 3;
            this.txtClientPort.Text = "13000";
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Location = new System.Drawing.Point(250, 39);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(47, 17);
            this.lblClientPort.TabIndex = 2;
            this.lblClientPort.Text = "PORT";
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(81, 36);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(129, 22);
            this.txtClientIP.TabIndex = 1;
            // 
            // lblClientIP
            // 
            this.lblClientIP.AutoSize = true;
            this.lblClientIP.Location = new System.Drawing.Point(55, 39);
            this.lblClientIP.Name = "lblClientIP";
            this.lblClientIP.Size = new System.Drawing.Size(20, 17);
            this.lblClientIP.TabIndex = 0;
            this.lblClientIP.Text = "IP";
            this.lblClientIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(47, 281);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(416, 35);
            this.txtMessage.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(493, 281);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 35);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtChatBox
            // 
            this.txtChatBox.Location = new System.Drawing.Point(47, 362);
            this.txtChatBox.Multiline = true;
            this.txtChatBox.Name = "txtChatBox";
            this.txtChatBox.ReadOnly = true;
            this.txtChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatBox.Size = new System.Drawing.Size(566, 197);
            this.txtChatBox.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 597);
            this.Controls.Add(this.txtChatBox);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxServer);
            this.Name = "Form1";
            this.Text = "TCP/IP Chat Application";
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label lblClientIP;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtChatBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

