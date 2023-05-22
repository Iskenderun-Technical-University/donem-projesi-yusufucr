using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yksdenemekonutakip
{
    public partial class hesapolustur : Form
    {
        public hesapolustur()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxad.Text == string.Empty || textBoxsoyad.Text == string.Empty || maskedTextBoxtelefon.Text == string.Empty || maskedTextBoxsifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Formu Eksiksiz Doldurunuz!!!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into kullanicilar (ad,soyad,telefon,sifre) values (@p1,@p2,@p3,@p4)", bgl.baglanti()); //Kayıt verilerinin veritabanına alınması

                komut.Parameters.AddWithValue("@p1", textBoxad.Text);
                komut.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBoxtelefon.Text);
                komut.Parameters.AddWithValue("@p4", maskedTextBoxsifre.Text);


                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("-Kayıt Başarılı-");
                this.Close();
            }
        }

        private void textBoxad_TextChanged(object sender, EventArgs e)
        {
            textBoxad.Text = textBoxad.Text.ToUpper();
            textBoxad.SelectionStart = textBoxad.Text.Length;
        }

        private void textBoxsoyad_TextChanged(object sender, EventArgs e)
        {
            textBoxsoyad.Text = textBoxsoyad.Text.ToUpper();
            textBoxsoyad.SelectionStart = textBoxsoyad.Text.Length;
        }
    }
}
