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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-70UES6S;Initial Catalog=Uyeler;Integrated Security=True";  //veritabanından gerekli baglantıyı çeker.
        SqlConnection connect = new SqlConnection(conString);

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("Kullanıcı/Üye, Site’ye girilen yolcu bilgilerinin içeriğinden ve doğruluğundan sorumlu olduğunu, sisteme bilgileri girdikten sonra değişiklik yapılamayacağını, bununla ilgili bir zarar oluşması halinde tüm sorumluluğun kendisinde olduğunu kabul beyan ve taahhüt eder.Kullanıcı / Üye, site üzerinde aracılık edilerek sunulan hizmetlerde, Tedarikçi firmalar ve Kullanıcı / Üye arasında doğabilecek uyuşmazlıklardan, zararlardan ve / veya taleplerden Şirket’in sorumlu tutulamayacağını, tek muhatabın ilgili hizmetin asıl sağlayıcısı olduğunu kabul beyan ve taahhüt eder.Kuralları ve gizlilik sözleşmesini okuduğunu, anladığını, kabul ettiğini ve kendisi ile ilgili olarak verdiği bilgilerin doğruluğunu onayladığını kabul beyan ve taahhüt eder .", "Üyelik sözleşmesi");
        }
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("E-posta ve/veya şifre boş geçilemez.","Uyarı");
                }

                else
                {
                    //bağlantı açık degilse açalım
                    connect.Open();
                    string kayit = "insert into bilgi(adi,soyadi,e_posta,telefon,sifre) values (@ad,@soyad,@e_posta,@telefon,@sifre)";
                    SqlCommand komut = new SqlCommand(kayit, connect);

                    komut.Parameters.AddWithValue("@ad", textBox1.Text);

                    komut.Parameters.AddWithValue("@soyad", textBox2.Text);

                    komut.Parameters.AddWithValue("@e_posta", textBox3.Text);

                    komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);

                    komut.Parameters.AddWithValue("@sifre", textBox4.Text);

                    komut.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("üye olundu");
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Beklenilmeyen bir hata oluştu" + hata.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sunduğumuz hizmetlerden yararlanmanız sırasında, size ve talep ettiğin hizmetlere ilişkin olarak elde ettiğimiz bilgilerin ne şekilde kullanılacağı ve korunacağı,Gizlilik Politikası'nda belirtilen şartlara tabidir.", "Kişisel verilerin korunması ve Gizlilik politikası");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
