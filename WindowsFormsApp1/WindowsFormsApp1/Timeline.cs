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
    class Timeline
    {
        public void timeline_extractor()
        {
            string scriptPath = @"C:\Users\gslad\Documents\GitHub\Diplomski\Python\timeline\timeline.py";

            Process pr = new Process();

            pr.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", scriptPath);
            pr.StartInfo.WorkingDirectory = @"C:\Users\gslad\Documents\GitHub\Diplomski\Python\timeline";
            pr.Start();
            pr.WaitForExit();
            pr.Close();

                DialogResult message = MessageBox.Show("Zelite li pogledati rezultate?", "Upozorenje", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    Process.Start(@"C:\Users\gslad\Documents\GitHub\Diplomski\Python\timeline\dat.txt");
                }
                else
                {
                    MessageBox.Show("Rezultati ove skripte su pohranjeni u: C:\\Users\\gslad\\Documents\\GitHub\\Diplomski\\Python\\timeline", "Rezultati");
                }
                
            }
    }
}
