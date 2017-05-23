using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        faylYarat yarat; string h = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            string s = Form1.s; int a = 0; 
            yarat = new faylYarat(s);
            yarat.Read();
            while ((h = yarat.sr.ReadLine()) != null)
            {
                a = h.IndexOf('*');
                comboBox1.Items.Add(h.Substring(0, a));
            }
        }
    }
}
