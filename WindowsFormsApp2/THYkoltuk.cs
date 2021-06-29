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
       
        static string conString = "Data Source=DESKTOP-2HUCK6R;Initial Catalog=rezervasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
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

            connect.Open();
            SqlCommand commands = new SqlCommand("insert into rezervasyon_tablo(ad_soyad,telefon,row_no,tc,nereden,nereye,gidis_tarihi,donus_tarihi,ucret) values('" + textBox1.Text + "','" + maskedTextBox2.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+ "','" +textBox4.Text + "')", connect);

            commands.ExecuteNonQuery();
            connect.Close();
           
            this.Hide();
            ödeme frm = new ödeme();
            frm.Show();


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public int ucret;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime gidis_tarihi = Convert.ToDateTime(dateTimePicker2.Text);
            DateTime donus_tarihi = Convert.ToDateTime(dateTimePicker1.Text);
            TimeSpan  sonuc = donus_tarihi - gidis_tarihi;//fark işlemi için kullanılır
            label10.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label10.Text)*100;
            textBox4.Text = ucret.ToString();


          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dateTimePicker1.Visible = false;
                label4.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = true;
                label4.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            rezervasyon frm = new rezervasyon();
            frm.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
