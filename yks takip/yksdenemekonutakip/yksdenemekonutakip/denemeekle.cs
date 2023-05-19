using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yksdenemekonutakip
{
    public partial class denemeekle : Form
    {
        public denemeekle()
        {
            InitializeComponent();
        }

        private void denemeekle_Load(object sender, EventArgs e)
        {
            groupBoxayt.Enabled = false;
            groupBoxtyt.Enabled = false;    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxtyt.Enabled = radioButton1.Checked;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxayt.Enabled = radioButton2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==radioButton2.Checked) {

                
                MessageBox.Show("Lütfen deneme türünü seçiniz!!!");

            }
            else
            {

                MessageBox.Show("KAYIT BAŞARILI");
                this.Close();
            }
        }
    }
}
