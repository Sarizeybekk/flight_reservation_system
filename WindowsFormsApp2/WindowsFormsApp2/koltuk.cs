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
    public partial class koltuk : Form
    {
        public koltuk()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-70UES6S;Initial Catalog=sirket;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void koltuk_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from THY", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[0] + ".           " + oku[1].ToString()+ "    -     " + oku[2].ToString() + "  gidiş tarihi:" + oku[3].ToString() + "  dönüş tarihi" + oku[4].ToString() + "  ücret:" + oku[5].ToString());
            }
            baglan.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Hide();
            THYkoltuk frm = new THYkoltuk();
            frm.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli koltuklar dolu oldugunu gösterir");
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Koltugun boş oldugunu gösterir");
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
