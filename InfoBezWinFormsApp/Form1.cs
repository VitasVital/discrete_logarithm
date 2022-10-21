using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSecurityAPI.Models;
using InformationSecurityAPI.Shifrovanie;

namespace InfoBezWinFormsApp
{
    public partial class Form1 : Form
    {
        private Shifrovanie6 shifr_6;
        private TextRequest6 textRequest6;
        public Form1()
        {
            InitializeComponent();
            shifr_6 = new Shifrovanie6();
            textRequest6 = new TextRequest6();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textRequest6.input_text = textBox2.Text;
            textRequest6.bit_count = textBox1.Text;

            textRequest6 = shifr_6.Result_1(textRequest6);

            textBox7.Text = textRequest6.P;
            textBox8.Text = textRequest6.Q;
            textBox9.Text = textRequest6.e;
            textBox10.Text = textRequest6.d;
            textBox11.Text = textRequest6.fi_n;
            textBox12.Text = textRequest6.n;

            textBox13.Text = textRequest6.result_1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRequest6.result_2 = "";
            textRequest6.input_d = textBox4.Text;
            textRequest6.input_n = textBox5.Text;
            textRequest6.cryptogram = textBox3.Text;

            textRequest6 = shifr_6.Result_2(textRequest6);

            textBox6.Text = textRequest6.result_2;
        }
    }
}
