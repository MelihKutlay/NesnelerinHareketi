using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesnelerinHareketi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 35)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 490)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 420)
            {
                timer3.Stop();
                timer4.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <=195)
            {
                timer4.Stop();
                timer5.Start();
            }
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <=125)
            {
                timer5.Stop();
                timer6.Start();
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >=285)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 240)
            {
                timer7.Stop();
                {
                    MessageBox.Show("DÖNGÜ BAŞARILI BİR ŞEKİLDE TAMAMLANDI");
                }
            }
        }

    }
}
