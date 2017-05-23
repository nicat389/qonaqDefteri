using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label fileNameLabel;
        TextBox fileName;
        Button confirm;
        faylYarat yarat ;
        Form2 form2 = new Form2();
        public static string s = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            fileNameLabel = Elements.element.myLabel("Yaradılacaq faylın adı: ", 95, 61);
            fileNameLabel.Font = new Font(fileNameLabel.Font.FontFamily, 10);
            fileName = Elements.element.myTextBox(241, 20, 248, 61);
            confirm = Elements.element.myButton("Fayl yarat", 114, 35, 375, 100);
            confirm.Click += Confirm_Click;
            this.Controls.Add(fileNameLabel);
            this.Controls.Add(fileName);
            this.Controls.Add(confirm);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            yarat = new faylYarat(fileName.Text);
            s = fileName.Text;
            yarat.Create();
            form2.ShowDialog();
        }
    }
}
