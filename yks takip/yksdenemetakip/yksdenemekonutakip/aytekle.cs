using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yksdenemekonutakip
{
    public partial class aytekle : Form
    {
        public aytekle()
        {
            InitializeComponent();
        }
        public string telefon;
        private void aytekle_Load(object sender, EventArgs e)
        {
            labeltelefon.Text = telefon;
        }
        
        sqlbaglanti bgl=new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxdenemadi.Text == string.Empty)
            {

                MessageBox.Show("Deneme Adı Giriniz!");
            }

            else {
            SqlCommand komut = new SqlCommand("insert into denemelerayt (denemead,denemetarih,telefon,aytmat,aytfen,sos1,sos2) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti()); //Kayıt verilerinin veritabanına alınması

            komut.Parameters.AddWithValue("@p1", textBoxdenemadi.Text);
            komut.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p3", labeltelefon.Text);
            komut.Parameters.AddWithValue("@p4", numericUpDownaytmat.Value);
            komut.Parameters.AddWithValue("@p5", numericUpDownaytfen.Value);
            komut.Parameters.AddWithValue("@p6", numericUpDownsos1.Value);
            komut.Parameters.AddWithValue("@p7", numericUpDownsos2.Value);



            komut.ExecuteNonQuery();
            bgl.baglanti().Close();



            MessageBox.Show("KAYIT BAŞARILI-Sayfayı Yenileyin");
            this.Close();
            }



        }

        private void textBoxdenemadi_TextChanged(object sender, EventArgs e)
        {
            textBoxdenemadi.Text = textBoxdenemadi.Text.ToUpper();
            textBoxdenemadi.SelectionStart = textBoxdenemadi.Text.Length;
            
        }
    }
}
