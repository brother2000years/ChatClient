namespace ChatClient
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
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIpAddr = new System.Windows.Forms.TextBox();
            this.btnEnterToChat = new System.Windows.Forms.Button();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(295, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 75);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод сообщения";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Enabled = false;
            this.tbMessage.Location = new System.Drawing.Point(6, 19);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(284, 75);
            this.tbMessage.TabIndex = 2;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Controls.Add(this.tbIpAddr);
            this.groupBox2.Controls.Add(this.btnEnterToChat);
            this.groupBox2.Controls.Add(this.tbNickname);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключение";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Никнейм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт сервера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP-Адрес сервера";
            // 
            // tbPort
            // 
            this.tbPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPort.Location = new System.Drawing.Point(109, 47);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(80, 20);
            this.tbPort.TabIndex = 3;
            // 
            // tbIpAddr
            // 
            this.tbIpAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIpAddr.Location = new System.Drawing.Point(109, 12);
            this.tbIpAddr.Name = "tbIpAddr";
            this.tbIpAddr.Size = new System.Drawing.Size(80, 20);
            this.tbIpAddr.TabIndex = 2;
            // 
            // btnEnterToChat
            // 
            this.btnEnterToChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterToChat.Location = new System.Drawing.Point(295, 45);
            this.btnEnterToChat.Name = "btnEnterToChat";
            this.btnEnterToChat.Size = new System.Drawing.Size(97, 23);
            this.btnEnterToChat.TabIndex = 1;
            this.btnEnterToChat.Text = "Войти в чат";
            this.btnEnterToChat.UseVisualStyleBackColor = true;
            this.btnEnterToChat.Click += new System.EventHandler(this.btnEnterToChat_Click);
            // 
            // tbNickname
            // 
            this.tbNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNickname.Location = new System.Drawing.Point(255, 12);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(137, 20);
            this.tbNickname.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rtbMessages);
            this.groupBox3.Location = new System.Drawing.Point(12, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "История сообщений";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbMessages.Location = new System.Drawing.Point(3, 16);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(392, 135);
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьНастройкиToolStripMenuItem,
            this.сохранитьНастройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьНастройкиToolStripMenuItem
            // 
            this.загрузитьНастройкиToolStripMenuItem.Name = "загрузитьНастройкиToolStripMenuItem";
            this.загрузитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.загрузитьНастройкиToolStripMenuItem.Text = "Загрузить настройки";
            // 
            // сохранитьНастройкиToolStripMenuItem
            // 
            this.сохранитьНастройкиToolStripMenuItem.Name = "сохранитьНастройкиToolStripMenuItem";
            this.сохранитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.сохранитьНастройкиToolStripMenuItem.Text = "Сохранить настройки";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(199, 45);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Выйти";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(433, 417);
            this.Name = "Form1";
            this.Text = "ChatEvs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnterToChat;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIpAddr;
        private System.Windows.Forms.ToolStripMenuItem загрузитьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНастройкиToolStripMenuItem;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

