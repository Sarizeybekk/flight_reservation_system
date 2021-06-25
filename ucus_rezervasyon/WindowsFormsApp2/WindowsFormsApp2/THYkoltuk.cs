using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class THYkoltuk : Form
    {
        public THYkoltuk()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "12";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = "13";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = "14";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text = "15";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = "16";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text = "17";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "18";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.Text = "19";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox3.Text = "20";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox3.Text = "21";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox3.Text = "22";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox3.Text = "23";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox3.Text = "24";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox3.Text = "25";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox3.Text = "26";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox3.Text = "27";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox3.Text = "28";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox3.Text = "29";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox3.Text = "30";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button31.Visible = true;
            }
            else
            {
                button31.Visible = false;
            }

        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Hide();
            ödeme frm = new ödeme() ;
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
