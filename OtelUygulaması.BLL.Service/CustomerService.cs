using OtelUygulaması.Bll.IService;
using OtelUygulaması.Dal.IRepositories;
using OtelUygulaması.Dal.Repositories;
using OtelUygulaması.Entities;
using OtelUygulaması.ViewModel.CustomerVM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.BLL.Service
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepositories _customerRepo;
        public CustomerService()
        {
            _customerRepo = new CustomerRepositories();
        }
        public int Create(CustomerCreateVm vm)
        {
            Customer customer = new Customer()
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Phone = vm.Phone,
                Email = vm.Email

            };
            return _customerRepo.Create(customer);
        }

        public int Delete(int customerID)
        {
            return _customerRepo.Delete(_customerRepo.GetByID(customerID));
        }

        public List<CustomerListVm> GetAll()
        {
           List<CustomerListVm> cvmList = new List<CustomerListVm>();

            foreach (Customer customer in _customerRepo.GetAll())
            {
                CustomerListVm cvm = new CustomerListVm()
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Phone = customer.Phone,
                    Email = customer.Email


                };
                cvmList.Add(cvm);
            }
            return cvmList;
        }

        public int Update(CustomerUpdateVm vm)
        {
            Customer customer = _customerRepo.GetByID(vm.ID);

            customer.FirstName = vm.FirstName;
            customer.LastName = vm.LastName;
            customer.Phone = vm.Phone;
            customer.Email = vm.Email;

            return _customerRepo.Update(customer);
        }
    }
}
