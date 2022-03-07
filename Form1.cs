using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apple
{
    public partial class Form1 : Form
    {

        string[] appleClass = { "Mac", "iPod", "iPhone", "iPad" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(appleClass);
            listBox1.SetSelected(0, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox2.Items.Clear();

            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add("MacBook");
                listBox2.Items.Add("Mac mini");
                listBox2.Items.Add("iMac");
                listBox2.Items.Add("MacPro");
            }

            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add("iPod shuffle");
                listBox2.Items.Add("iPod nano");
                listBox2.Items.Add("iPod touch");
                listBox2.Items.Add("iPod classic");
            }

            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add("iPhone 4");
                listBox2.Items.Add("iPhone 4S");
                listBox2.Items.Add("iPhone 5");
            }

            if (listBox1.SelectedIndex == 3)
            {
                listBox2.Items.Add("iPad 2");
                listBox2.Items.Add("iPad mini");
            }
        }
    }
}
