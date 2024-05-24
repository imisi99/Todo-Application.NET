using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
                checkBox1.Checked = false;

            if (checkBox2.Checked == true)
                checkBox2.Checked = false;

            if (checkBox3.Checked == true)
                checkBox3.Checked = false;

            if(checkBox1.Text == "")
            {
                checkBox1.Text = textBox1.Text;
                textBox1.Clear();
                checkBox1.Checked = false;
            }

            else if (checkBox2.Text == "")
            {
                checkBox2.Text = textBox1.Text;
                textBox1.Clear();
                checkBox2.Checked = false;
            }

            else if(checkBox3.Text == "")
            {
                checkBox3.Text = textBox1.Text;
                textBox1.Clear();
                checkBox3.Checked = false;
            }
            else
            {
                MessageBox.Show("You should probably clear up those todos before you add a new one", "Clear off todo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox1.Text != "")
            {
                MessageBox.Show($"Congratulation on {checkBox1.Text}");
                checkBox1.Text = "";
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked && checkBox2.Text != "")
            {
                MessageBox.Show($"Congratulation on {checkBox2.Text}");
                checkBox2.Text = "";
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked && checkBox3.Text != "")
            {
                MessageBox.Show($"Congratulation on {checkBox3.Text}");
                checkBox3.Text = "";
                checkBox3.Checked = false;
            }

            else
            {
                MessageBox.Show("No todo was checked, tick the todo that has been done and try again", "Not checked");
            }

        }
    }
}
