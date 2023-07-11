using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Contains('+'))
            {
                Hesap_makinesi topla = new Hesap_makinesi();
                string[] sayilar = textBox1.Text.Split('+');
                int sonuc = topla.topla(sayilar);
                textBox1.Text = sonuc.ToString();
            }

            else if(textBox1.Text.ToString().Contains('-'))
            {
                Hesap_makinesi cıkar = new Hesap_makinesi();
                string[] sayilar = textBox1.Text.Split('-');
                int sonuc = cıkar.cıkar(sayilar);
                textBox1.Text = sonuc.ToString();
            }

            else if(textBox1.Text.ToString().Contains('*')) 
            {
                Hesap_makinesi carp = new Hesap_makinesi();
                string[] sayilar = textBox1.Text.Split('*');
                int sonuc = carp.carp(sayilar);
                textBox1.Text = sonuc.ToString();
            }

            else if (textBox1.Text.ToString().Contains('/'))
            {
                Hesap_makinesi bol = new Hesap_makinesi();
                string[] sayilar = textBox1.Text.Split('/');
                int sonuc = bol.bol(sayilar);
                textBox1.Text = sonuc.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
