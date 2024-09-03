using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleApp
{
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            sum =num1+num2;
            MessageBox.Show("Sum: " + sum.ToString());
        }

        private void hello_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                button2_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } 
}
