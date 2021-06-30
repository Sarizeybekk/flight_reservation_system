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
    public partial class ödeme : Form
    {
        public ödeme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-70UES6S;Initial Catalog=rezervasyon;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            label7.Text = textBox4.Text;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            label9.Text = textBox3.Text;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ödeme_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay = 1; ay < 13; ay++)
            {
                comboBox1.Items.Add(ay);

            }
            for (yil = 21; yil < 30; yil++)
            {
                comboBox2.Items.Add(yil);
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand commands = new SqlCommand("insert into rezervasyon_tablo(kart_adsoyad,kart_no,kart_ay,kart_yil,kart_cvv,bakiye) values('" + textBox1.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')", baglan);

            commands.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ödemeniz yapılmıştır. İyi Uçuşlar");
        }

        
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from rezervasyon_tablo", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox5.Text=(oku[9].ToString());
            }
            baglan.Close();
           
        }
    }
}
