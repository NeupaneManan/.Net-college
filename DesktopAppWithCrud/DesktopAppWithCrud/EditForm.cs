﻿using System;
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
    public partial class EditForm : Form
    {
        public EditForm(Student s)  
        {
            InitializeComponent();
            this.s = s;
        }
    }
}
