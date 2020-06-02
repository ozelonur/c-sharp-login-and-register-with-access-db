using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydolLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void girisYapButon_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0; Data Source=veritabani.accdb");
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanicilar WHERE kullaniciAdi = '"+kullaniciAdiTxt.Text+"' AND sifre ='"+sifreTxt.Text+"'";
            OleDbDataReader okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Şifre Hatalı!");
            }


        }
    }
}
