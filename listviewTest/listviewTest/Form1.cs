using listviewTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listviewTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //whoops
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Cheeseburger");
            item.SubItems.Add("5.75");
            item.SubItems.Add("While Supplies Last");
            listView1.Items.Add(item);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.Items.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}