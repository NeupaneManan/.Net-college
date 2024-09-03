using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            List<AddressList> list = Datalayer.GetAddressList();
            cmbAddress.DataSource = list;
            cmbAddress.DisplayMember = "AddressName";
            cmbAddress.valueMember = "AddressId";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
