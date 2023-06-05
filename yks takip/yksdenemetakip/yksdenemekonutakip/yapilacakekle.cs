using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace yksdenemekonutakip
{
    public partial class yapilacakekle : Form
    {
        public yapilacakekle()
        {
            InitializeComponent();
        }

      

        public string telefon;
        private void yapilacakekle_Load(object sender, EventArgs e)
        {
            labeltelefon.Text=telefon;
        }

        sqlbaglanti bgl=new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {

                MessageBox.Show("Lütfen Metin Giriniz!");
            }

            else
            {

                SqlCommand komut = new SqlCommand("insert into yapilacaklar (yapilacaklar,tarih,telefon) values (@p1,@p2,@p3)", bgl.baglanti()); //Kayıt verilerinin veritabanına alınması

                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p3", labeltelefon.Text);
               





                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("KAYIT BAŞARILI");
                this.Close();
               


            }
        }
    }
}
