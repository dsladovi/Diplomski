using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forensic_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ap_credentialsBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("poruka", "naslov", MessageBoxButtons.YesNo);
            
        }

        private void prefetchBTN_Click(object sender, EventArgs e)
        {

        }

        private void reg_recentDocsBTN_Click(object sender, EventArgs e)
        {

        }

        private void timelineBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
