using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NavigationTest
{
    public partial class MyNavigator : UserControl
    {
        public MyNavigator()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        int itemCount = 0;

        public void AddItem(string itemText)
        {
            itemText = "        " + itemText;
            Label label = new Label();
            label.AutoSize = false;
            label.Image = Properties.Resources.alert_lrg;
            label.Text = itemText;
            label.Height = 30;
            label.Width = this.Width;
            label.Margin = new Padding(5,0,5,0);
            label.BackColor = Color.AliceBlue;
            label.Location = new Point(0, 30 * itemCount);
            label.MouseEnter += Label_MouseEnter;
            label.MouseLeave += Label_MouseLeave;
            label.Click += Label_Click;
            label.ImageAlign = ContentAlignment.MiddleLeft;
            label.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label);
            itemCount++;
            this.Height = 30 * itemCount + 10;
        }

        public void AddSplitter(string text)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Text = text;
            label.Height = 30;
            label.Width = 300;
            label.Margin = new Padding(0);
            label.BackColor = Color.AliceBlue;
            label.Location = new Point(0, 30 * itemCount);
            label.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label);
            itemCount++;
            this.Height = 30 * itemCount + 10;
        }

        public void Clear()
        {
            this.Controls.Clear();
            itemCount = 0;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            MessageBox.Show(label.Text);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.BackColor = Color.AliceBlue;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            
            var label = sender as Label;
            label.BackColor = Color.DodgerBlue;
        }

        XmlDocument dataSource = null;
        public void AddDataSource(XmlDocument xmlDocument)
        {
            dataSource = xmlDocument;
        }

        public void Search(string keyWord)
        {
            XmlNode root = dataSource.DocumentElement;
            foreach(XmlNode node in root.ChildNodes)
            {
            }
        }
    }
}
