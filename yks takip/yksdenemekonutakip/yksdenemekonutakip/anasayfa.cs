using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yksdenemekonutakip
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        public string telefon;

       

       
        



        private void buttondenemeekle_Click(object sender, EventArgs e)
        {
            tytekle frm= new tytekle();
            frm.telefon = labeltelefon.Text;
            
            frm.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            aytekle frm = new aytekle();
            frm.telefon = labeltelefon.Text;
            frm.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {


            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-FMJQ9I6Q\SQLEXPRESS; Initial Catalog = ykstakip; Integrated Security = True");

            {



                labeltelefon.Text = telefon;
                SqlCommand komut = new SqlCommand("select denemead,denemetarih,turkce,mat,fen,sos,toplamnet,id from denemeler where telefon=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", labeltelefon.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand komut2 = new SqlCommand("select denemead,denemetarih,aytmat,aytfen,sos1,sos2,toplamnet,id from denemelerayt where telefon=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p2", labeltelefon.Text);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;


                dataGridView1.Columns["denemead"].HeaderText = "Yayın";
                dataGridView1.Columns["denemetarih"].HeaderText = "Deneme Tarih";
                dataGridView1.Columns["turkce"].HeaderText = "Türkçe";
                dataGridView1.Columns["mat"].HeaderText = "Matematik";
                dataGridView1.Columns["fen"].HeaderText = "Fen";
                dataGridView1.Columns["sos"].HeaderText = "Sosyal";
                dataGridView1.Columns["toplamnet"].HeaderText = "Toplam";
                dataGridView1.Columns["id"].HeaderText = "id";

                dataGridView2.Columns["denemead"].HeaderText = "Yayın";
                dataGridView2.Columns["denemetarih"].HeaderText = "Deneme Tarih";
                dataGridView2.Columns["aytmat"].HeaderText = "Matematik";
                dataGridView2.Columns["aytfen"].HeaderText = "Fen";
                dataGridView2.Columns["sos1"].HeaderText = "Sos 1";
                dataGridView2.Columns["sos2"].HeaderText = "Sos 2";
                dataGridView2.Columns["toplamnet"].HeaderText = "Toplam";
                dataGridView2.Columns["id"].HeaderText = "id";



            }
        }

        private void buttonyenile_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-FMJQ9I6Q\SQLEXPRESS; Initial Catalog = ykstakip; Integrated Security = True");

            {



               
                SqlCommand komut = new SqlCommand("select denemead,denemetarih,turkce,mat,fen,sos,toplamnet,id from denemeler where telefon=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", labeltelefon.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand komut2 = new SqlCommand("select denemead,denemetarih,aytmat,aytfen,sos1,sos2,toplamnet,id from denemelerayt where telefon=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p2", labeltelefon.Text);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;


                dataGridView1.Columns["denemead"].HeaderText = "Yayın";
                dataGridView1.Columns["denemetarih"].HeaderText = "Deneme Tarih";
                dataGridView1.Columns["turkce"].HeaderText = "Türkçe";
                dataGridView1.Columns["mat"].HeaderText = "Matematik";
                dataGridView1.Columns["fen"].HeaderText = "Fen";
                dataGridView1.Columns["sos"].HeaderText = "Sosyal";
                dataGridView1.Columns["toplamnet"].HeaderText = "Toplam";
                dataGridView1.Columns["id"].HeaderText = "id";

                dataGridView2.Columns["denemead"].HeaderText = "Yayın";
                dataGridView2.Columns["denemetarih"].HeaderText = "Deneme Tarih";
                dataGridView2.Columns["aytmat"].HeaderText = "Matematik";
                dataGridView2.Columns["aytfen"].HeaderText = "Fen";
                dataGridView2.Columns["sos1"].HeaderText = "Sos 1";
                dataGridView2.Columns["sos2"].HeaderText = "Sos 2";
                dataGridView2.Columns["toplamnet"].HeaderText = "Toplam";
                dataGridView2.Columns["id"].HeaderText = "id";


            }


        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void buttonsil_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Denemenin Satırına Çift Tıklayıp Sonra Butona Baınız!!!");
            }
            else
            {

            

            if (Convert.ToInt32(textBox1.Text) < 1000)
            {
                SqlCommand komut = new SqlCommand("delete from denemeler where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı - Sayfayı Yenileyiniz");
                    textBox1.Text= string.Empty;

            }
            else
            {
                SqlCommand komut = new SqlCommand("delete from denemelerayt where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı - Sayfayı Yenileyiniz");
                    textBox1.Text= string.Empty;
            }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }


        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
        }

       
    }
    }
    

