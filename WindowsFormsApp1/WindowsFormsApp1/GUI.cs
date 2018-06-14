using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void apPassBTN_Click(object sender, EventArgs e)
        {
            UserPass password = new UserPass();
            password.run_script();
        }
        

        private void prefetchBTN_Click(object sender, EventArgs e)
        {
            Prefetch pref = new Prefetch();
            pref.prefetching();
            
        }
        private void regRecentBTN_Click(object sender, EventArgs e)
        {
            // Otvaranje Browse forme kako bi se odabrala datoteka koja je potrebna za izvrsiti skriptu
            openFileDialog.RestoreDirectory = true;
            string path2 = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path2 = openFileDialog.FileName;
                RecentDocs recent = new RecentDocs();
                recent.run_script(path2);

            }
        }
            private void timelineBTN_Click(object sender, EventArgs e)
        {
            // Otvaranje Browse forme kako bi se odabrala datoteka koja je potrebna za izvrsiti skriptu
            openFileDialog.RestoreDirectory = true;
            string path3 = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path3 = openFileDialog.FileName;
                MessageBox.Show(path3, "timeline");
            }
        }

        
    }
}
