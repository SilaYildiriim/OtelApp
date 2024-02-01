using OtelUygulaması.Bll.IService;
using OtelUygulaması.BLL.Service;
using OtelUygulaması.ViewModel.CustomerVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelUygulamasıUI.CustomerForms
{
    public partial class CustomerCreate : Form
    {
        ICustomerService _service;
        
        public CustomerCreate( )
        {
            InitializeComponent();
            _service = new CustomerService();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerCreateVm cvm = new CustomerCreateVm
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEMail.Text,
                Phone = txtPhone.Text,
            };
           int success =  _service.Create( cvm );
            if ( success == 0 )
            {
                MessageBox.Show("Failed");
                return;
            }
            MessageBox.Show("New customer added.");
            this.Close();

        }
    }
}
