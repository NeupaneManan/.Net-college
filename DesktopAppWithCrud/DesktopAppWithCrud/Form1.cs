using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppWithCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewStudentsForm form = new NewStudentsForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectRows.Count == 1)
            {
                Student student = new Student();
                s.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                s.Name = dataGridView1s/
          

            }
        }
    }
}
