using OtelUygulaması.BLL.Service;
using OtelUygulaması.ViewModel.EmployeeVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelUygulamasıUI.EmployeeForms
{
    public partial class EmployeeForm : Form
    {
        IEmployeeService _service;
        public EmployeeForm()
        {
            InitializeComponent();
            _service = new EmployeeService();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeCreate employeeCreate = new EmployeeCreate();
            employeeCreate.ShowDialog();
            FillEmployeeList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                EmployeeUpdate employeeUpdate = new EmployeeUpdate(selectedId);
                this.Hide();

                employeeUpdate.ShowDialog();
                this.Show();
                FillEmployeeList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                _service.Delete(selectedId);
                MessageBox.Show("Silindi");
            }


            else
            {
                MessageBox.Show("Geçerli bir satır seçin");

            }

            
                
            
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {


            FillEmployeeList();

        }

        private void FillEmployeeList()
        {
            _service = new EmployeeService();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _service.GetAll();

        }
        private void EmployeeForm_Load_1(object sender, EventArgs e)
        {
            FillEmployeeList();
        }


    }
}

