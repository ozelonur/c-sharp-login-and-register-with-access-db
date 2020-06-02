using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login_register_forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void kayitOlButon_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0; Data Source=veritabani.accdb");
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO kullanicilar (ad, soyad, kullaniciAdi, tcKimlikNo, sifre)" +
                    "VALUES ('" + adTxt.Text + "','" + soyadTxt.Text + "','" + kAdiTxt.Text + "','" + tcTxt.Text + "','" + sifreTxt.Text + "')";
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirildi.");
            baglanti.Close();
            this.Close();
        }
    }
}
