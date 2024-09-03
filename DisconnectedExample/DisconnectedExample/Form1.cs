using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DisconnectedExample
{
    public partial class Form1 : Form
    {
        private const string conString = "Data Source = localhost; Initial Catalog = ContactDb1; Integrated Security =SSPI ";
        private SqlConnection conObj = new SqlConnection(conString);
        private SqlCommand comObj;// = new SqlCommand();
        private SqlDataAdapter adapterObj;// = new SqlDataAdapter();
        private SqlCommandBuilder builderObj;
        private DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            comObj = new SqlCommand("Select * from ContactList", conObj);
            adapterObj = new SqlDataAdapter(comObj);
            builderObj = new SqlCommandBuilder(adapterObj);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapterObj.Fill(ds, "ContactList");
            dataGridView1.DataSource = ds.Tables["ContactList"];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            adapterObj.Update(ds.Tables["ContactList"]);
            MessageBox.Show("Saved");
        }
    }
}
