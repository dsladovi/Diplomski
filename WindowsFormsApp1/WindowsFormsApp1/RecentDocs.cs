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
    public class RecentDocs
    {
        public void run_script(string put)
        {
            string outputFile = @"-o C:\Users\gslad\Documents\GitHub\Diplomski\Python\RecentDocsMRU-gotovo\rezultati.txt";
            string scriptPath = @"C:\Users\gslad\Documents\GitHub\Diplomski\Python\RecentDocsMRU-gotovo\recentdocs-mru.py -f "+put+" "+outputFile;

            Process p = new Process();

                p.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", scriptPath);
                p.StartInfo.WorkingDirectory = @"C:\Users\danijels\Documents\GitHub\Dipl\Diplomski\Python\RecentDocsMRU-gotovo";
                p.Start();
                p.WaitForExit();
                p.Close();

            DialogResult message = MessageBox.Show("Zelite li pogledati rezultate?","Upozorenje",MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                Process.Start(@"C:\Users\gslad\Documents\GitHub\Diplomski\Python\RecentDocsMRU-gotovo\rezultati.txt");
            }
            else
            {
                MessageBox.Show("Rezultati ove skripte su pohranjeni u: C:\\Users\\gslad\\Documents\\GitHub\\Diplomski\\Python\\RecentDocsMRU - gotovo", "Rezultati");
            }
        }

    }
}
