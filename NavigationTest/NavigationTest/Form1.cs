using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationTest
{
    public partial class Form1 : Form
    {
            MyNavigator myNavigator = new MyNavigator();
        public Form1()
        {
            InitializeComponent();
            textBox1.LostFocus += TextBox1_LostFocus;
            textBox1.LostFocus += TextBox1_LostFocus1;
            this.Click += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            myNavigator.Visible = false;
        }

        private void TextBox1_LostFocus1(object sender, EventArgs e)
        {
            myNavigator.Visible = false;
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(!myNavigator.Visible)
            {
                myNavigator.Visible = true;
            }

            myNavigator.Clear();
            myNavigator.AddItem("Search " + textBox1.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.BackColor = Color.Yellow;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myNavigator.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Height + 3);
            myNavigator.Visible = false;
            myNavigator.Width = textBox1.Width;

            // Must add the navigator to the Form itself.
            this.Controls.Add(myNavigator);

            // Add to the contain first then bring to front, or it will not have effect.
            myNavigator.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            myNavigator.Clear();
            myNavigator.AddSplitter("MENU ───────────────");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddItem("Test --> test --> tset");
            myNavigator.AddSplitter("MORE ───────────────");
            myNavigator.AddItem("Search on Baidu");
            myNavigator.Visible = true;
        }


    }
}
