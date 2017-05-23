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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Label myLabel, name, surName,comment;
        TextBox nameText, surNameText, commentText;
        Button send, readComment;
        faylYarat yarat; string s;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
            myLabel = Elements.element.myLabel("Şərh yaz!",10,10);
            myLabel.Font = new Font(myLabel.Font.FontFamily, 10);
            name = Elements.element.myLabel("Ad:", 10, 40);
            surName = Elements.element.myLabel("Soyad:", 10, 65);
            comment = Elements.element.myLabel("Şərh:", 10, 90);
            nameText = Elements.element.myTextBox(400, 20, name.Left+50, 35);
            surNameText = Elements.element.myTextBox(400, 20, name.Left + 50, 60);
            commentText = Elements.element.myTextBox(400, 20, name.Left + 50, 90);
            commentText.Multiline = true;
            commentText.Height = 200;

            send = Elements.element.myButton("Göndər",130,70, 470, 220);
            send.BackColor = Color.Yellow;
            send.Click += Send_Click;

            readComment = Elements.element.myButton("Şərh oxu", 130, 70, 60, commentText.Top + 250);
            readComment.BackColor = Color.Azure;
            readComment.Click += ReadComment_Click;

            this.Controls.Add(myLabel);
            this.Controls.Add(name);
            this.Controls.Add(surName);
            this.Controls.Add(comment);
            this.Controls.Add(nameText);
            this.Controls.Add(surNameText);
            this.Controls.Add(commentText);
            this.Controls.Add(send);
            this.Controls.Add(readComment);
        }

        private void ReadComment_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            s = Form1.s;
            yarat = new faylYarat(s);
            yarat.Write(nameText.Text, surNameText.Text, commentText.Text);
            

            nameText.Text = "";
            surNameText.Text = "";
            commentText.Text = "";
        }
    }
}
