using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PopupSearchBox;

namespace NavigationTest
{
    public partial class Form1 : Form
    {
        SearchBox popupSearchBox = new SearchBox();

        public Form1()
        {
            InitializeComponent();
            textBox1.LostFocus += TextBox1_LostFocus;
            textBox1.LostFocus += TextBox1_LostFocus1;
            this.Click += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            popupSearchBox.Visible = false;
        }

        private void TextBox1_LostFocus1(object sender, EventArgs e)
        {
            popupSearchBox.Visible = false;
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(!popupSearchBox.Visible)
            {
                popupSearchBox.Visible = true;
            }

            popupSearchBox.Clear();
            popupSearchBox.AddItem("Search " + textBox1.Text);
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
            popupSearchBox.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Height + 3);
            popupSearchBox.Visible = false;
            popupSearchBox.Width = textBox1.Width;

            // Must add the navigator to the Form itself.
            this.Controls.Add(popupSearchBox);

            // Add to the contain first then bring to front, or it will not have effect.
            popupSearchBox.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            popupSearchBox.Clear();
            popupSearchBox.AddSplitter("MENU ───────────────");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddItem("Test --> test --> tset");
            popupSearchBox.AddSplitter("MORE ───────────────");
            popupSearchBox.AddItem("Search on Baidu");
            popupSearchBox.Visible = true;
        }


    }
}
