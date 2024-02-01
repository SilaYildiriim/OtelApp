using OtelUygulamasıUI.CustomerForms;

namespace OtelUygulamasıUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerMainForm customerForm = new CustomerMainForm();
            customerForm.ShowDialog();
        }
    }
}
