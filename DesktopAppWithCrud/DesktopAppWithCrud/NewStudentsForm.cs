using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppWithCrud
{
    public partial class NewStudentsForm : Form
    {
        public NewStudentsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Address = txtAddress.Text;
            student.Phone = txtPhone.Text;
            student.DoB = dtpDoB.Value;
            DataAccessLayer dbLayer = new DataAccessLayer();
            if (dbLayer.Register(student))
            {
                MessageBox.Show("Student Registered Sucessfully");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Registration Failed, Please try again");
            }
        }
        public void ClearForm()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dtpDoB.Value = DateTime.Today;
        }
    }
   }
