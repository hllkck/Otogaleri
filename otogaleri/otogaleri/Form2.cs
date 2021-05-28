using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otogaleri
{
    public partial class Form2 : Form
    {
        Form1 frm2 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "hilay" && textBox2.Text == "12345")
            {
                frm2.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı  adı veya şifre yanlış");


        }
    }
}
