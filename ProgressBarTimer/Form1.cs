using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DialogResult sonuc;
        DialogResult sonuc2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Yellow;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                sonuc = MessageBox.Show("Karıştırma İşlemi bitti sıradaki işleme geçmek istiyorsanız evet butonuna tıklayınız", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (sonuc == DialogResult.Yes)
                {
                    timer2.Start();
                }
                else
                {
                    sonuc2 = MessageBox.Show("Uygulamayı yeniden başlatmak istediğinizde burdaki buton'da tamama tıklayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (sonuc2 == DialogResult.OK)
                    {
                        timer2.Start();
                    }
                    else
                    {
                        MessageBox.Show("Uygulamadan Çıkılıyor...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
             
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.Blue;
            }
            if (progressBar2.Value % 20 == 0)
            {
                label2.BackColor = Color.Purple;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                sonuc = MessageBox.Show("Çırpma İşlemi bitti sıradaki işleme geçmek istiyorsanız evet butonuna tıklayınız", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (sonuc == DialogResult.Yes)
                {
                    timer3.Start();
                }
                else
                {
                    sonuc2 = MessageBox.Show("Uygulamayı yeniden başlatmak istediğinizde burdaki buton'da tamama tıklayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (sonuc2 == DialogResult.OK)
                    {
                        timer3.Start();
                    }
                    else
                    {
                        MessageBox.Show("Uygulamadan Çıkılıyor...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Black;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                sonuc = MessageBox.Show("Malzemeleri ekleme ve karıştırma İşlemi bitti sıradaki işleme geçmek istiyorsanız evet butonuna tıklayınız", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (sonuc == DialogResult.Yes)
                {
                    timer4.Start();
                }
                else
                {
                    sonuc2 = MessageBox.Show("Uygulamayı yeniden başlatmak istediğinizde burdaki buton'da tamama tıklayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (sonuc2 == DialogResult.OK)
                    {
                        timer4.Start();
                    }
                    else
                    {
                        MessageBox.Show("Uygulamadan Çıkılıyor...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 1;
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.Orange;
            }
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.Brown;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Pasta pişirme işlemi bitti :)", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}