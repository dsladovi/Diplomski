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

            DialogResult message = MessageBox.Show("Zelite li pogledati rezultate?", "Upozorenje", MessageBoxButtons.YesNo);

            if (message == DialogResult.Yes)
            {
                Process.Start(@"C:\Users\danijels\Documents\GitHub\Dipl\Diplomski\Python\APs\userIpass.txt");
                DialogResult detalji = MessageBox.Show("Dali želite vidjeti detaljnije podatke ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (detalji == DialogResult.Yes)
                {
                    Process.Start(@"C:\Users\danijels\Documents\GitHub\Dipl\Diplomski\Python\APs\Credentials2.txt");
                }
                else
                {
                    MessageBox.Show("Rezultati ove skripte su pohranjeni u: C:\\Users\\danijels\\Documents\\GitHub\\Dipl\\Diplomski\\Python\\APs\n\n Credentials2.txt\n Profili.txt\n userIpass.txt\n", "Rezultati");
                }
            }
            else
            {
                MessageBox.Show("Rezultati ove skripte su pohranjeni u: C:\\Users\\danijels\\Documents\\GitHub\\Dipl\\Diplomski\\Python\\APs\n\n Credentials2.txt\n Profili.txt\n userIpass.txt\n", "Rezultati");
            }
        }
    }
}
