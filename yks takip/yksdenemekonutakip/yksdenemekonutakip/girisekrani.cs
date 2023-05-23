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

   
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
       
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from kullanicilar where telefon = @p1 and sifre = @p2", bgl.baglanti());    //Şifre ve Tc yi gerekli yerlerden alma
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtelefon.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBoxsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anasayfa frm = new anasayfa();
                frm.telefon = maskedTextBoxtelefon.Text;
                frm.Show();                                     //Şifre Ve Tc veri tabanıyla karşılaştırıldı 
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Telefon veya Şifre!!!");          //Şifre ve Tc yanlışsa
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifremiunuttum nw = new sifremiunuttum();
            nw.Show();
        }

        private void girisekrani_Load(object sender, EventArgs e)
        {

        }
    }


    
}

