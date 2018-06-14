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
    class UserPass
    {
        public void run_script()
        {
            string scriptPath = @"C:\Users\danijels\Documents\GitHub\Dipl\Diplomski\Python\APs\AP_acces_points_passwords.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", scriptPath);
            p.StartInfo.WorkingDirectory = @"C:\Users\danijels\Documents\GitHub\Dipl\Diplomski\Python\APs";
            p.Start();
            p.WaitForExit();
            p.Close();
            
        }
    }
}
