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
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1,2,3,4,5,6,7,8,9,10,11,12,13,14" && comboBox2.Text == "2015,2016" && comboBox3.Text == "Audi,Fiat,Renault,Seat,Wolswagen" && comboBox4.Text == "128.000,63.000,74.000,81.000,117.000"
               && comboBox5.Text == "Heacback,Sedan" && comboBox6.Text == "Beyaz,Sarı,Gri,Kırmızı,Siyah,Mavi,Turuncu" && comboBox7.Text == "Otomatik,Manuel" && comboBox8.Text == "Benzin,Dizel"
               && comboBox9.Text == "0,İkinciel")
            {
            string yol = "";
            yol = comboBox1.Text + comboBox3.Text + comboBox2.Text+ comboBox4.Text + comboBox5.Text + comboBox6.Text + comboBox7.Text + comboBox8.Text + comboBox9.Text;
            pictureBox1.Image = Image.FromFile(yol + ".jpg");
                
            }
            else MessageBox.Show("Girdiğiniz seçeneklerde arabamız yoktur. ");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            pictureBox1.Image = null;
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
