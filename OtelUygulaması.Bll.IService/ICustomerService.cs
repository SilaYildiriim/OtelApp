using OtelUygulaması.ViewModel.CustomerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Bll.IService
{
    public interface ICustomerService
    {
        int Create(CustomerCreateVm vm);
        int Update(CustomerUpdateVm vm);
        int Delete(int employeeID);
        List<CustomerListVm> GetAll();
       
    }
}
