using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yksdenemekonutakip
{
    public partial class tytekle : Form
    {
        public tytekle()
        {
            InitializeComponent();
        }
       
    
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBoxdenemadi.Text == string.Empty)
            {

                MessageBox.Show("Deneme Adı Giriniz!");
            }

            else { 

            SqlCommand komut = new SqlCommand("insert into denemeler (denemead,denemetarih,telefon,turkce,mat,fen,sos) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti()); //Kayıt verilerinin veritabanına alınması

                    komut.Parameters.AddWithValue("@p1", textBoxdenemadi.Text);
                    komut.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@p3", labeltelefon.Text);
                    komut.Parameters.AddWithValue("@p4", numericUpDownturkce.Value);
                    komut.Parameters.AddWithValue("@p5", numericUpDownmat.Value);
                    komut.Parameters.AddWithValue("@p6", numericUpDownfen.Value);
                    komut.Parameters.AddWithValue("@p7", numericUpDownsos.Value);
                    




                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                   
                
                MessageBox.Show("KAYIT BAŞARILI-Sayfayı Yenileyin");
                this.Close();


            }
            

        }

        public string telefon;
        private void tytekle_Load(object sender, EventArgs e)
        {
            labeltelefon.Text = telefon;
        }

        private void textBoxdenemadi_TextChanged(object sender, EventArgs e)
        {
            textBoxdenemadi.Text = textBoxdenemadi.Text.ToUpper();
            textBoxdenemadi.SelectionStart = textBoxdenemadi.Text.Length;
        }
    }
        }

        
   


