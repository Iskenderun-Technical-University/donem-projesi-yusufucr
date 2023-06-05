using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace yksdenemekonutakip
{
    public partial class yapilacaklar : Form
    {
        public yapilacaklar()
        {
            InitializeComponent();
        }

        public string telefon;
        private void kacgunkaldi_Load(object sender, EventArgs e)
        {
            

            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-FMJQ9I6Q\SQLEXPRESS; Initial Catalog = ykstakip; Integrated Security = True");

            {



                labeltelefon.Text = telefon;


                SqlCommand komut = new SqlCommand("select tarih,yapilacaklar,id from yapilacaklar where telefon=@p1", baglanti);

                komut.Parameters.AddWithValue("@p1", labeltelefon.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

             


                dataGridView1.Columns["tarih"].HeaderText = " Tarih ";
                dataGridView1.Columns["yapilacaklar"].HeaderText = " Görev ";
                dataGridView1.Columns["id"].HeaderText = " id ";


            }
        }

        private void buttonyapilacakeekle_Click(object sender, EventArgs e)
        {
            yapilacakekle frm = new yapilacakekle();
            frm.telefon = labeltelefon.Text;
            frm.Show();
            
           



        }




        sqlbaglanti bgl = new sqlbaglanti();
        private void buttonyapilacaksil_Click(object sender, EventArgs e)
        {

            if (textBoxİD.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Denemenin Satırına Çift Tıklayıp Sonra Butona Basınız !!");
            }
            else
            {



                
                    SqlCommand komut = new SqlCommand("delete from yapilacaklar where id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBoxİD.Text));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Başarılı");
                    textBoxİD.Text = string.Empty;
                    buttonyenile.PerformClick();

               
            }

        }

       

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxİD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void buttonyenile_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-FMJQ9I6Q\SQLEXPRESS; Initial Catalog = ykstakip; Integrated Security = True");

            {



                labeltelefon.Text = telefon;


                SqlCommand komut = new SqlCommand("select tarih,yapilacaklar,id from yapilacaklar where telefon=@p1", baglanti);

                komut.Parameters.AddWithValue("@p1", labeltelefon.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;




                dataGridView1.Columns["tarih"].HeaderText = " Tarih ";
                dataGridView1.Columns["yapilacaklar"].HeaderText = " Görev ";
                dataGridView1.Columns["id"].HeaderText = " id ";


            }
        }
    }

   
    
}
