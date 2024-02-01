using OtelUygulaması.Dal.IRepositories;
using OtelUygulaması.Dal.Repositories;
using OtelUygulaması.Entities;
using OtelUygulaması.ViewModel.EmployeeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.BLL.Service
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepositories _employeeRepositories;
        public EmployeeService()
        {
            _employeeRepositories = new EmployeeRepositories();
        }
        public int Create(EmployeeCreateVM employeeCreateVm)
        {
            var employeeCreate = new Entities.Employee
            {

                FirstName = employeeCreateVm.FirstName,
                LastName = employeeCreateVm.LastName,
                Position = employeeCreateVm.EmployeePosition,
                
            };
            return _employeeRepositories.Create(employeeCreate);

        }

        public int Delete(int id)
        {
            var employeeDelete = _employeeRepositories.GetById(id);
            
                return _employeeRepositories.Delete(employeeDelete);

            
            
        }

        public ICollection<EmployeeListVM> GetAll()
        {
            ICollection<EmployeeListVM> _vsm = _employeeRepositories.GetAll().Select(e => new EmployeeListVM { Id = e.Id, FirstName = e.FirstName, LastName = e.LastName,EmployeePosition=e.Position  }).ToList();
            return _vsm;
        }

        public int GetById(int id)
        {
            var employeDetail = _employeeRepositories.GetById(id);
            if (employeDetail != null)
            {
                var employeeDetailVm = new EmployeeListVM
                {
                    
                    FirstName = employeDetail.FirstName,
                    LastName = employeDetail.LastName,
                    EmployeePosition = employeDetail.Position,

                    

                };
                return employeDetail.Id;
                
            }
            return 0;
            
        }

        

        public int Update(EmployeeUpdateVM employeeUpdateVm)
        {
            Employee employee=_employeeRepositories.GetById(employeeUpdateVm.Id);
            if (employee != null)
            {
                employee.FirstName = employeeUpdateVm.FirstName;
                employee.LastName = employeeUpdateVm.LastName;
                employee.Position = employeeUpdateVm.EmployeePosition;

            }
            return _employeeRepositories.Update(employee);



        }
    }
}
