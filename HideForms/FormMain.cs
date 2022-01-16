namespace HideForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee("123");
            FormViewEmployee formViewEmployee = new FormViewEmployee();
            FormViewNewUpdates formViewNewUpdates = new FormViewNewUpdates(this, new List<Form>{ formViewEmployee });
            formViewEmployee.Show();
            formViewNewUpdates.Show();
            Hide();
        }
    }
}