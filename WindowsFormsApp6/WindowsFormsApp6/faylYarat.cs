using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class faylYarat
    {
        FileInfo f { get; set; }
        public string k;
        private StreamWriter sw { get; set; }
         public StreamReader sr { get; set; }
        // public bool check = false;
        public faylYarat(string a)
        {
            k = a;
            f = new FileInfo(a + ".txt");

        }

        public void Create()
        {
            if (f.Exists)
            {
                MessageBox.Show("Bu fayl mövcuddur!");
            }
            else
            {
                MessageBox.Show("Fayl yaradıldı!");
                File.Create(f.FullName).Close();
                // check = true;
            }
        }

        public void Write(params string[] k)
        {
            string s="";
            
            if (f.Exists)
            {
                sw = f.AppendText();
               
            }

            else
            {
                sw = f.CreateText();
            }
            for (int i = 0; i < k.Length; i++)
            {
                s += k[i] + "*";
            }

            sw.WriteLine(s);
            sw.Close();
        }

        public void Read()
        {
            string s = null; int a = 0;
            sr = new StreamReader(f.Name, System.Text.Encoding.GetEncoding(1251));

        }
    }
}
