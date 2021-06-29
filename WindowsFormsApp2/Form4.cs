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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-2HUCK6R;Initial Catalog=sirket;Integrated Security=True");
        SqlConnection baglan2 = new SqlConnection("Data Source=DESKTOP-2HUCK6R;Initial Catalog=Uyeler;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  baglan.Open();
            SqlCommand komut = new SqlCommand("select *from Bilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString() + "    -     " + oku[2].ToString());
            }
            baglan.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglan2.Open();
            SqlCommand komut = new SqlCommand("select *from Bilgi", baglan2);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString() + "    -     " + oku[2].ToString() + oku[3].ToString() + ".           " + oku[4].ToString() + "    -     " + oku[5].ToString());
            }
            baglan.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand commands = new SqlCommand("insert into THY(nereden,nereye,gidis_tarihi,donus_tarihi,) values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") +"')", baglan);

            commands.ExecuteNonQuery();
            baglan.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
