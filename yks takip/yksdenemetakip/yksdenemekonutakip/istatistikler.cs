using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;


namespace yksdenemekonutakip
{
    public partial class istatistikler : Form
    {
        public istatistikler()
        {
            InitializeComponent();
        }

        public string telefon;
        sqlbaglanti bgl = new sqlbaglanti();
        private void istatistikler_Load(object sender, EventArgs e)
        {


            labeltelefon.Text = telefon;

            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM denemeler WHERE telefon = @p3;", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p3", labeltelefon.Text);
            
            int kayitSayisi = (int)komut3.ExecuteScalar();
            label3.Text = "Toplam Deneme: " + kayitSayisi.ToString();

            SqlCommand komut4 = new SqlCommand("SELECT MAX(toplamnet) FROM denemeler WHERE telefon = @p4;", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p4", labeltelefon.Text);

            int kayitSayisi2 = (int)komut4.ExecuteScalar();
            label5.Text = "En Yüksek Net: " + kayitSayisi2.ToString();


            SqlCommand komut5 = new SqlCommand("SELECT MIN(toplamnet) FROM denemeler WHERE telefon = @p5;", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p5", labeltelefon.Text);

            int kayitSayisi3 = (int)komut5.ExecuteScalar();
            label6.Text = "En Düşük Net: " + kayitSayisi3.ToString();

            SqlCommand komut6 = new SqlCommand("SELECT COUNT(*) FROM denemelerayt WHERE telefon = @p6;", bgl.baglanti());
            komut6.Parameters.AddWithValue("@p6", labeltelefon.Text);

            int kayitSayisi4 = (int)komut6.ExecuteScalar();
            label9.Text = "Toplam Deneme: " + kayitSayisi4.ToString();

            SqlCommand komut7 = new SqlCommand("SELECT MAX(toplamnet) FROM denemelerayt WHERE telefon = @p7;", bgl.baglanti());
            komut7.Parameters.AddWithValue("@p7", labeltelefon.Text);

            int kayitSayisi5 = (int)komut7.ExecuteScalar();
            label8.Text = "En Yüksek Net: " + kayitSayisi5.ToString();


            SqlCommand komut8 = new SqlCommand("SELECT MIN(toplamnet) FROM denemelerayt WHERE telefon = @p8;", bgl.baglanti());
            komut8.Parameters.AddWithValue("@p8", labeltelefon.Text);

            int kayitSayisi6 = (int)komut8.ExecuteScalar();
            label7.Text = "En Düşük Net: " + kayitSayisi6.ToString();




            SqlCommand komut = new SqlCommand("SELECT AVG(turkce),AVG(mat),AVG(fen),AVG(sos),AVG(toplamnet) FROM denemeler WHERE telefon = @p1;", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltelefon.Text);


            using (SqlDataReader reader = komut.ExecuteReader())
            {
               
                if (reader.Read())
                {
                    double turkceOrt = Convert.ToDouble(reader[0]);
                    double matOrt = Convert.ToDouble(reader[1]);
                    double fenOrt = Convert.ToDouble(reader[2]);
                    double sosOrt = Convert.ToDouble(reader[3]);
                    double topOrt = Convert.ToDouble(reader[4]);



                    // Seri oluşturun ve verileri ekle
                    Series series = new Series();
                    series.ChartType = SeriesChartType.Column;
                    series.Points.AddXY("Türkçe", turkceOrt);
                    series.Points.AddXY("Matematik", matOrt);
                    series.Points.AddXY("Fen", fenOrt);
                    series.Points.AddXY("Sosyal Bilgiler", sosOrt);
                    series.Points.AddXY("Genel Net", topOrt);

                    // Seriyi grafik alanına ekle
                    chart1.Series.Add(series);

                    // Form üzerine grafik kontrolünü ekleyin
                    this.Controls.Add(chart1);
                }
                SqlCommand komut2 = new SqlCommand("SELECT AVG(aytmat),AVG(aytfen),AVG(sos1),AVG(sos2),AVG(toplamnet) FROM denemelerayt WHERE telefon = @p2;", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", labeltelefon.Text);


                using (SqlDataReader reader2 = komut2.ExecuteReader())
                {

                    if (reader2.Read())
                    {
                        double aytmatOrt = Convert.ToDouble(reader2[0]);
                        double aytfenOrt = Convert.ToDouble(reader2[1]);
                        double sos1Ort = Convert.ToDouble(reader2[2]);
                        double sos2Ort = Convert.ToDouble(reader2[3]);
                        double topOrt = Convert.ToDouble(reader2[4]);



                        // Seri oluşturun ve verileri ekle
                        Series series2 = new Series();
                        series2.ChartType = SeriesChartType.Column;
                        series2.Points.AddXY("Matematik", aytmatOrt);
                        series2.Points.AddXY("Fen", aytfenOrt);
                        series2.Points.AddXY("Sos1", sos1Ort);
                        series2.Points.AddXY("Sos2", sos2Ort);
                        series2.Points.AddXY("Genel Net", topOrt);

                        // Seriyi grafik alanına ekle
                        chart2.Series.Add(series2);

                        // Form üzerine grafik kontrolünü ekleyin
                        this.Controls.Add(chart2);
                    }
                }
            }

     

        }
    }
}
