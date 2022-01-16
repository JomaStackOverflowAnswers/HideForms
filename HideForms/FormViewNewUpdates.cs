using System;
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
    public partial class FormViewNewUpdates : Form
    {
        private readonly Employee employee;
        private readonly Form parent;
        private readonly List<Form> formsToClose;

        public FormViewNewUpdates(Employee employee, Form parent, List<Form> formsToClose)
        {
            InitializeComponent();
            this.employee = employee;
            this.parent = parent;
            this.formsToClose = formsToClose;
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach(var form in formsToClose)
            {
                form.Close();//form.Hide(); //Hide in case you need to reuse the form.
            }
            Close();
            parent.Show();// Show the parent form.
        }

        private void FormViewNewUpdates_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var form in formsToClose)
            {
                form.Close();
            }
            parent.Show();
        }
    }
}
