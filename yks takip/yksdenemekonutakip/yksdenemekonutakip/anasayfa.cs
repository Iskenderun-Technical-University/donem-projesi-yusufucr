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

        sqlbaglanti bgl = new sqlbaglanti();
        private void anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ykstakipDataSet2.denemelerayt' table. You can move, or remove it, as needed.
            this.denemeleraytTableAdapter.Fill(this.ykstakipDataSet2.denemelerayt);
            // TODO: This line of code loads data into the 'ykstakipDataSet1.denemeler' table. You can move, or remove it, as needed.
            this.denemelerTableAdapter1.Fill(this.ykstakipDataSet1.denemeler);
            // TODO: This line of code loads data into the 'ykstakipDataSet.denemeler' table. You can move, or remove it, as needed.
       
            labeltelefon.Text= telefon;
            
        }

       

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
    }
    }

