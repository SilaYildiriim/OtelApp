using OtelUygulaması.BLL.Service;
using OtelUygulaması.Entities.Enums;
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
    public partial class EmployeeUpdate : Form
    {
        IEmployeeService employeeService;
        int _selectedId;
        public EmployeeUpdate(int selectedId)
        {
            InitializeComponent();
            employeeService = new EmployeeService();

            _selectedId = selectedId;
        }

        string[] Position = Enum.GetNames(typeof(EmployePosition));

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var emplyeevm = new EmployeeUpdateVM
            {
                Id = _selectedId,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                EmployeePosition = comboBox1.Text,



            };
            int success = employeeService.Update(emplyeevm);
            if (success == 0)
            {
                MessageBox.Show("Güncelleme işlemi başarısız!");
                return;
            }
            MessageBox.Show("Basariyla güncellendi.");
            this.Close();
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            
        }

        private void EmployeeUpdate_Load_1(object sender, EventArgs e)
        {
            foreach (var item in Position)
            {
                comboBox1.Items.Add(item);

            }
        }
    }
}
