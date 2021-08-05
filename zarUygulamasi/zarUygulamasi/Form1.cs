using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace zarUygulamasi
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a, b;

            Random rastgele = new Random();

            a = rastgele.Next(1,7);
            b = rastgele.Next(1,7);

            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "audio\\zar.wav";
            ses.Play();
            



            if (a == 1)
            {
                pictureBox1.ImageLocation = "image\\1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "image\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "image\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "image\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "image\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "image\\6.png";
            }

            //....

            if (b == 1)
            {
                pictureBox2.ImageLocation = "image\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "image\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "image\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "image\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "image\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "image\\6.png";
            }

            if (a == 1 && b == 1)
            {
                MessageBox.Show("Tebrikler Hepyek !!");
            }
            if (a == 2 && b == 2)
            {
                MessageBox.Show("Tebrikler Dübara !!");
            }
            if (a == 3 && b == 3)
            {
                MessageBox.Show("Tebrikler Düse!!");
            }
            if (a == 4 && b == 4)
            {
                MessageBox.Show("Tebrikler Dörtcar!!");
            }
            if (a == 5 && b == 5)
            {
                MessageBox.Show("Tebrikler Dübeş!!");
            }
            if (a == 6 && b == 6)
            {
                MessageBox.Show("Tebrikler Düşeş!!");
            }

        }
    }
}
