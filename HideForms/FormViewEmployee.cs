﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideForms
{
    public partial class FormViewEmployee : Form
    {
        private readonly Employee employee;

        public FormViewEmployee(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
    }
}
