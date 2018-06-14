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
    public class Prefetch
    {

        public void prefetching()
        {
            
            string scriptPath = @"C:\Users\danijels\Desktop\dd\Python\WindowsPrefetch+\prefetch.py";
           
            Process p = new Process();
                  
            p.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", scriptPath);
            
            p.Start();
            p.WaitForExit();
            p.Close();

        }
        
    }
}
