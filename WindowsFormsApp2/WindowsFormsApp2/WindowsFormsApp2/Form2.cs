using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataReader oku;
        SqlCommand komut;



        public Form2()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) & !string.IsNullOrEmpty(textBox2.Text))
            {
                string e_posta = textBox1.Text;
                string sifre = textBox2.Text;
                con = new SqlConnection("Data Source=DESKTOP-70UES6S;Initial Catalog=Uyeler;Integrated Security=True");
                komut = new SqlCommand();
                con.Open();
                komut.Connection = con;
                komut.CommandText = "SELECT * FROM Bilgi WHERE e_posta='" + textBox1.Text +
                    "'And sifre ='" + textBox2.Text +"'";
                oku = komut.ExecuteReader();

                if (oku.Read())

                    if (oku["uyeid"].ToString() == "2")
                    {
                        this.Hide();
                        Form4 frm = new Form4();
                        frm.Show();
                    }
                    else { 
                    MessageBox.Show("Kullanıcı girişi yaptınız");
                        this.Hide();
                        rezervasyon frm = new rezervasyon();
                        frm.Show();
                    }
                else
                {
                    MessageBox.Show("Yanlış eposta şifre kombinasyonu");
                }
                     con.Close();
            }
            else { MessageBox.Show("Lütfen eposta Ve Şifre Giriniz."); }
        } 




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "E-posta")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "E-posta";
                textBox1.ForeColor = Color.Transparent;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "şifre";
                textBox2.ForeColor = Color.Transparent;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
   
        }
    

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

 
    }
}

