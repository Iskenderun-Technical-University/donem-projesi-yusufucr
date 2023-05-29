using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace yksdenemekonutakip
{
    public partial class yapilacaklar : Form
    {
        public yapilacaklar()
        {
            InitializeComponent();
        }

        private void kacgunkaldi_Load(object sender, EventArgs e)
        {

        }

        private void buttonyapilacakeekle_Click(object sender, EventArgs e)
        {
            yapilacakekle frm = new yapilacakekle();
            frm.Show();
        }
    }
    
}
