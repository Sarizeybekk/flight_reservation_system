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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        string sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            sqlbaglantisi1 bgln = new sqlbaglantisi1();
            SqlCommand komut = new SqlCommand("Select *From Bilgi Where e_posta='" + textBox1.Text.ToString() + "'", bgln.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadresin = ("sultansrzybk@gmail.com");
                    String sifre = ("");//mail şifremiz girildiginde mail atacaktır.
                    String smptsrvr = "smtp.gmail.com";
                    String kime = (oku["e_posta"].ToString());
                    String konu = ("sifre hatırlatma talebi");
                    String yaz = ("Sayın," + "Bizden" + tarih + "tarihinde şifre hatırlatma talebinde bulundunuz." + "\n" + "şifreniz:" + oku["şifre"]
                        .ToString() + "\nİyi günler");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş oldugunuz bilgiler uyuşuyor.Şifreniz mail adresine gönderilmiştir.");
                    this.Hide();
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("mail gönderme Hatası", Hata.Message);
                }



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
