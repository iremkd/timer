using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pckapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 5;
        int dakika = 0;
        int saat = 0;
        private object exit;

        private void button1_Click(object sender, EventArgs e)
        {
            if (hour1.Text != "" && minute1.Text != "")
            {
                
                dakika = Convert.ToInt32(minute1.Text);
                saat = Convert.ToInt32(hour1.Text);
                timer1.Start();
                this.TransparencyKey = Color.Transparent;
                this.BackColor = Color.White;
                this.Width = 445;
                this.Height = 100;
                this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                this.Top= Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
                hour1.Visible = false;
                minute1.Visible = false;
                ayarla.Visible = false;
                exittt.Visible = false;

                //yerleştirme
                Point lblyer = new Point(25,5);
                label2.Location = lblyer;
                label2.Font = new Font(label2.Font.FontFamily, 16);

                //saat
                Point lblsaat = new Point(35, 35);
                hour2.Location = lblsaat;
                hour2.Font = new Font(hour2.Font.FontFamily, 20);

                //dakika
                Point lbldakika = new Point(180, 35);
                minute2.Location = lbldakika;
                minute2.Font = new Font(minute2.Font.FontFamily, 20);

                //saniye
                Point lblsaniye = new Point(350, 35);
                second.Location = lblsaniye;
                second.Font = new Font(second.Font.FontFamily, 20);


            }
            else
            {
                MessageBox.Show("Boş değer girilemez.","UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye >= 0 && dakika >= 0 && saat >= 0)
            {
                second.Text = saniye.ToString("00");
                minute2.Text = dakika.ToString("00");
                hour2.Text = saat.ToString("00");
                if (saniye == 0 && dakika > 0)
                {
                    dakika--;
                    saniye = 5;
                }
                if (saniye == 0 && dakika == 0 && saat > 0)
                {
                    saniye = 5;
                    saat--;
                    dakika = 5;

                }
                if (saniye == 0 && dakika == 0 && saat == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Bilgisayarınız Kapanmak Üzere!!");
                   // System.Diagnostics.Process.Start("shutdown","-s"); //pc kapatma kodu
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hour1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //özel karakter ve harf girişini yasaklıyor.
        }

        private void minute1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //özel karakter ve harf girişini yasaklıyor.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a==DialogResult.Yes)
                Application.Exit();
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult c;
           c= colorDialog1.ShowDialog();
            if (c==DialogResult.OK)
            {
                label2.ForeColor = colorDialog1.Color;
                hour2.ForeColor = colorDialog1.Color;
                minute2.ForeColor = colorDialog1.Color;
                second.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
             //e.Cancel = false;


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             
            //e.Cancel = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
                this.Show();
            }


        }

       

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
                Application.Exit();
        }
    }
}
