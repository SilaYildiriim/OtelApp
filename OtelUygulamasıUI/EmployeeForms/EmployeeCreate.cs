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
    public partial class EmployeeCreate : Form
    {
        IEmployeeService employeeService;
        public EmployeeCreate()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }
        string[] Position = Enum.GetNames(typeof(EmployePosition));
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var employeevm = new EmployeeCreateVM
            {
                
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                EmployeePosition = comboBox1.Text,

            };

            employeeService.Create(employeevm);

            MessageBox.Show("Create işlemi başarılı!");
            this.Close();
        }

        private void EmployeeCreate_Load(object sender, EventArgs e)
        {
            foreach (var item in Position)
            {
                comboBox1.Items.Add(item);

            }
        }
    }
}
