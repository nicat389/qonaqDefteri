using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class createElements
    {
        public Label myLabel(string text, int left ,int top)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.Left = left;
            label.Top = top;
            return label;
        }

        //public Label[] myLabelArr(string text, int count)
        //{
        //    Label[] label = new Label[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        label[i] = new Label();
        //        label[i].Text = text;
        //        label[i].AutoSize = true;
        //    }
        //    return label;
        //}
        public Button myButton(string text, int width, int height, int left, int top)
        {
            Button myButton = new Button();
            myButton.Text = text;
            myButton.Width = width;
            myButton.Height = height;
            myButton.Top = top;
            myButton.Left = left;
            return myButton;
        }

        public TextBox myTextBox(int width, int height, int left, int top)
        {
            TextBox myTextBox = new TextBox();
            myTextBox.Width = width;
            myTextBox.Height = height;
            myTextBox.Left = left;
            myTextBox.Top = top;
            return myTextBox;
        }
    }
}
