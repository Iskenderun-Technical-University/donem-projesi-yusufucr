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
