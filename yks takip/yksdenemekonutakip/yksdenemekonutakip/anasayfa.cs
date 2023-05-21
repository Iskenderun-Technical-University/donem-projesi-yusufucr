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
                SqlCommand komut = new SqlCommand("select denemead,denemetarih,turkce,mat,fen,sos,toplamnet from denemeler where telefon=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", labeltelefon.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand komut2 = new SqlCommand("select denemead,denemetarih,aytmat,aytfen,sos1,sos2,toplamnet from denemelerayt where telefon=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p2", labeltelefon.Text);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;


                dataGridView1.Columns["denemead"].HeaderText = "Yayın";
                dataGridView1.Columns["denemetarih"].HeaderText = "Tarih";
                dataGridView1.Columns["turkce"].HeaderText = "Türkçe";
                dataGridView1.Columns["mat"].HeaderText = "Matematik";
                dataGridView1.Columns["fen"].HeaderText = "Fen";
                dataGridView1.Columns["sos"].HeaderText = "Sosyal";
                dataGridView1.Columns["toplamnet"].HeaderText = "Toplam";

                dataGridView2.Columns["denemead"].HeaderText = "Yayın";
                dataGridView2.Columns["denemetarih"].HeaderText = "Tarih";
                dataGridView2.Columns["aytmat"].HeaderText = "Türkçe";
                dataGridView2.Columns["aytfen"].HeaderText = "Matematik";
                dataGridView2.Columns["sos1"].HeaderText = "Fen";
                dataGridView2.Columns["sos2"].HeaderText = "Sosyal";
                dataGridView2.Columns["toplamnet"].HeaderText = "Toplam";


            }
        }
    }
    }

