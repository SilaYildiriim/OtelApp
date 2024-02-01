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
    public partial class UpdateCustomer : Form
    {
        ICustomerService _service;
        CustomerUpdateVm _updateVm;
        
        public UpdateCustomer()
        {
            InitializeComponent();
            _service = new CustomerService();
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _updateVm.FirstName = txtFirstName.Text;
            _updateVm.LastName = txtLastName.Text;
            _updateVm.Phone = txtPhone.Text;
            _updateVm.Email = txtEMail.Text;
            _service.Update(_updateVm);
            btnUpdate.Enabled = false;
            RefreshList();
            
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            RefreshList();

        }

        public void RefreshList()
        {
            dataGridView1.DataSource = _service.GetAll();
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _updateVm = new CustomerUpdateVm();
                _updateVm.ID = (int)dataGridView1.SelectedRows[0].Cells[0].Value; ;
                _updateVm.FirstName = (string)dataGridView1.SelectedRows[0].Cells[1].Value; ;
                _updateVm.LastName = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                _updateVm.Email = (string)dataGridView1.SelectedRows[0].Cells[3].Value;
                _updateVm.Phone = (string)dataGridView1.SelectedRows[0].Cells[4].Value;

                txtFirstName.Text = _updateVm.FirstName.ToString();
                txtLastName.Text = _updateVm.LastName.ToString();
                txtEMail.Text = _updateVm.Email.ToString();
                txtPhone.Text = _updateVm.Phone.ToString();
            }

            else
                MessageBox.Show("Please select to one row");
        }
    }
}
