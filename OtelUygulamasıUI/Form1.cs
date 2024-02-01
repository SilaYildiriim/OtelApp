using OtelUygulamasıUI.EmployeeForms;

namespace OtelUygulamasıUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForms= new EmployeeForm();
            employeeForms.ShowDialog();
        }
    }
}
