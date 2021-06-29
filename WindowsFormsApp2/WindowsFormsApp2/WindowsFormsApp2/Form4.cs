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
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-70UES6S;Initial Catalog=Uyeler;Integrated Security=True");

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
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from Bilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString() + "    -     " + oku[2].ToString());
            }
            baglan.Close();
        }
    }
}
