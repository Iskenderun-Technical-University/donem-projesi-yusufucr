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
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifremiunuttum nw=new sifremiunuttum();
            nw.Show();
        }
    }
}
