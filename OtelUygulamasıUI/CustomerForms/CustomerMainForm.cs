using OtelUygulaması.Bll.IService;
using OtelUygulaması.BLL.Service;
using OtelUygulaması.Dal.IRepositories;
using OtelUygulaması.Entities;
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
    public partial class CustomerMainForm : Form
    {
        ICustomerService _service;
        public CustomerMainForm()
        {
            InitializeComponent();
            _service = new CustomerService();
        }
        public void RefreshList()
        {
            dataGridView1.DataSource = _service.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerCreate form = new CustomerCreate();
            form.ShowDialog();
            RefreshList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer form = new UpdateCustomer();
            form.ShowDialog();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this customer ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    CustomerListVm selectedCustomer = (CustomerListVm)dataGridView1.Rows[selectedRowIndex].DataBoundItem;
                    int id = selectedCustomer.Id;
                    _service.Delete(id);

                    RefreshList();
                }

                else
                    MessageBox.Show("Canceled");
                    return;


            }
        }
    }
}
