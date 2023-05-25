using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yksdenemekonutakip
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(maskedTextBoxtelefon.Text) || string.IsNullOrEmpty(maskedTextBoxsifre.Text))
            {
                MessageBox.Show("Lütfen Formu Eksiksiz Doldurunuz");
            }
            else
            {

           
            SqlCommand komut = new SqlCommand("UPDATE kullanicilar SET sifre=@p1 WHERE telefon=@p2", bgl.baglanti());  //Verilerin veritabanında güncellenmesi
            komut.Parameters.AddWithValue("@p1", maskedTextBoxsifre.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBoxtelefon.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Şifre Değiştirildi");
            this.Close();
            }

        }
    }
}
