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
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;


namespace WindowsFormsApp1
{
    public class Prefetch
    {

        public void prefetching()
        {

            string scriptPath = @"C:\Users\gslad\Documents\GitHub\Diplomski\Python\WindowsPrefetch+\prefetch.py";
           
            Process p = new Process();
                
                p.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", scriptPath);
                p.Start();
                p.WaitForExit();
                p.Close();

            DialogResult message = MessageBox.Show("Zelite li pogledati rezultate?", "Upozorenje", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                Process.Start(@"C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\Prefetch\PrefetchRezultati.txt");
            }
            else
            {
                MessageBox.Show("Rezultati ove skripte su pohranjeni u: C:\\Users\\gslad\\Documents\\GitHub\\Diplomski\\Rezultati\\Prefetch", "Rezultati");
            }

        }
        
    }
}
