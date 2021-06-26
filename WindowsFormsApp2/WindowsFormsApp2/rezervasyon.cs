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
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-70UES6S;Initial Catalog=sirket;Integrated Security=True");


        private void rezervasyon_Load(object sender, EventArgs e)
        {
           
           

        }
           

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "THY")
            {
                this.Hide();
                THYkoltuk frm = new THYkoltuk();
                frm.Show();
            }
            else if (comboBox3.SelectedItem == "PEGASUS")
                    { 
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else if(comboBox3.SelectedItem=="ANADOLU JET")
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("FFF");
            }
           
           
        }



        



    

     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void comboBox3_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (comboBox3.Text == "THY")
            {
                listBox1.Items.Clear();
                baglan.Open();
                SqlCommand komut = new SqlCommand("select *from THY", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                  listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString() + "    -     " + oku[2].ToString());
                }
                baglan.Close();
            }
        

            else if (comboBox3.Text == "PEGASUS")
            {
                listBox1.Items.Clear();
                baglan.Open();
                SqlCommand komut = new SqlCommand("select *from PEGASUS", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString() + "    -     " + oku[2].ToString());
                }
                baglan.Close();
            }
            else if (comboBox3.Text == "ANADOLU JET")
            {
                listBox1.Items.Clear();
                baglan.Open();
                SqlCommand komut = new SqlCommand("select *from ANADOLU_JET", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString() + "    -     " + oku[2].ToString());
                }
                baglan.Close();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
