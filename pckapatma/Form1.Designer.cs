namespace pckapatma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hour1 = new System.Windows.Forms.TextBox();
            this.minute1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DAKİKA = new System.Windows.Forms.Label();
            this.ayarla = new System.Windows.Forms.Button();
            this.exittt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hour2 = new System.Windows.Forms.Label();
            this.minute2 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hour1
            // 
            this.hour1.Location = new System.Drawing.Point(49, 50);
            this.hour1.MaxLength = 2;
            this.hour1.Name = "hour1";
            this.hour1.Size = new System.Drawing.Size(113, 20);
            this.hour1.TabIndex = 0;
            this.hour1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour1_KeyPress);
            // 
            // minute1
            // 
            this.minute1.Location = new System.Drawing.Point(261, 50);
            this.minute1.MaxLength = 2;
            this.minute1.Name = "minute1";
            this.minute1.Size = new System.Drawing.Size(123, 20);
            this.minute1.TabIndex = 1;
            this.minute1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minute1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SAAT";
            // 
            // DAKİKA
            // 
            this.DAKİKA.AutoSize = true;
            this.DAKİKA.Location = new System.Drawing.Point(290, 20);
            this.DAKİKA.Name = "DAKİKA";
            this.DAKİKA.Size = new System.Drawing.Size(46, 13);
            this.DAKİKA.TabIndex = 3;
            this.DAKİKA.Text = "DAKİKA";
            this.DAKİKA.Click += new System.EventHandler(this.label2_Click);
            // 
            // ayarla
            // 
            this.ayarla.Location = new System.Drawing.Point(49, 91);
            this.ayarla.Name = "ayarla";
            this.ayarla.Size = new System.Drawing.Size(115, 47);
            this.ayarla.TabIndex = 4;
            this.ayarla.Text = "Zamanı Ayarla";
            this.ayarla.UseVisualStyleBackColor = true;
            this.ayarla.Click += new System.EventHandler(this.button1_Click);
            // 
            // exittt
            // 
            this.exittt.Location = new System.Drawing.Point(261, 91);
            this.exittt.Name = "exittt";
            this.exittt.Size = new System.Drawing.Size(123, 47);
            this.exittt.TabIndex = 6;
            this.exittt.Text = "Çıkış";
            this.exittt.UseVisualStyleBackColor = true;
            this.exittt.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SAAT                DAKİKA             SANİYE";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // hour2
            // 
            this.hour2.AutoSize = true;
            this.hour2.Location = new System.Drawing.Point(115, 192);
            this.hour2.Name = "hour2";
            this.hour2.Size = new System.Drawing.Size(19, 13);
            this.hour2.TabIndex = 11;
            this.hour2.Text = "00";
            this.hour2.Click += new System.EventHandler(this.label5_Click);
            // 
            // minute2
            // 
            this.minute2.AutoSize = true;
            this.minute2.Location = new System.Drawing.Point(192, 192);
            this.minute2.Name = "minute2";
            this.minute2.Size = new System.Drawing.Size(19, 13);
            this.minute2.TabIndex = 12;
            this.minute2.Text = "00";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(271, 192);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(19, 13);
            this.second.TabIndex = 13;
            this.second.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(215, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(211, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sayacın Rengini Değiştirmek İçin Tıklayınız.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(448, 237);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute2);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exittt);
            this.Controls.Add(this.ayarla);
            this.Controls.Add(this.DAKİKA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minute1);
            this.Controls.Add(this.hour1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hour1;
        private System.Windows.Forms.TextBox minute1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DAKİKA;
        private System.Windows.Forms.Button ayarla;
        private System.Windows.Forms.Button exittt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hour2;
        private System.Windows.Forms.Label minute2;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

