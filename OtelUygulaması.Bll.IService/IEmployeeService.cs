using OtelUygulaması.ViewModel.EmployeeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.BLL.Service
{
    public interface IEmployeeService
    {

        int Create(EmployeeCreateVM employeeCreateVm);
        int Update(EmployeeUpdateVM employeeUpdateVm);
        int Delete(int id);

        
        
        ICollection<EmployeeListVM> GetAll();

        


    }
}
