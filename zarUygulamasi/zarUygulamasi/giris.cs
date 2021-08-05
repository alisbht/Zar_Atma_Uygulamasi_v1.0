using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarUygulamasi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 zarlar = new Form1();
            zarlar.Show();

            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
           
        }
    }
}
