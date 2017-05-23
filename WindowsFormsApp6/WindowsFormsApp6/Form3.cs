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
        faylYarat yarat; string h = ""; List<string> comments = new List<string>(); List<string> namesArr = new List<string>();
        Label name, comment;
        ComboBox names; ListBox commentsList;
        private void Form3_Load(object sender, EventArgs e)
        {
            
            name = Elements.element.myLabel("Adlar: ", 149, 48);
            name.Font = new Font(name.Font.FontFamily, 12);

            comment = Elements.element.myLabel("Şərhlər: ", 391, 48);
            comment.Font = new Font(name.Font.FontFamily, 12);

            names = Elements.element.myComboBox("Ad seçin: ", 130, 21, 149, 82);
            names.SelectedIndexChanged += Names_SelectedIndexChanged;

            commentsList = Elements.element.myListBox(340, 150, 394, 82);

            this.Controls.Add(name);
            this.Controls.Add(comment);
            this.Controls.Add(names);
            this.Controls.Add(commentsList);


            string s = Form1.s; int a = 0, j = 0;
            yarat = new faylYarat(s);
            yarat.Read();
            while ((h = yarat.sr.ReadLine()) != null)
            {
                a = h.IndexOf('*');
                names.Items.Add(h.Substring(0, a));
                

                for (int m = 0; m < h.Length; m++)
                {
                    if (h[m] == '*')
                    {
                        j = m;
                    }
                }
                comments.Add(h.Substring(j + 1, h.Length - j - 1));
            }



        }

        private void Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            commentsList.Items.Clear();
            commentsList.Items.Add(comments[names.SelectedIndex]);
        }

       
    }
}
