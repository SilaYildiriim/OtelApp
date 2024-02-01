using OtelUygulaması.ViewModel.BookingVM;
using OtelUygulaması.ViewModel.CustomerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Bll.IService
{
    public interface IBookingService
    {
        int Create(BookingCreateVm vm);
        int Update(BookingUpdateVm vm);
        int Delete(int bookingID);
        List<BookingListVm> GetAll();
    }
}
