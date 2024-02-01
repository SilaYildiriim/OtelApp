using OtelUygulaması.Bll.IService;
using OtelUygulaması.Dal.IRepositories;
using OtelUygulaması.Dal.Repositories;
using OtelUygulaması.Entities;
using OtelUygulaması.ViewModel.BookingVM;
using OtelUygulaması.ViewModel.CustomerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.BLL.Service
{
    public class BookingService : IBookingService
    {
        IBookingRepositories _bookingRepo;
        public BookingService()
        {
            _bookingRepo = new BookingRepositories();
        }

        public int Create(BookingCreateVm vm)
        {
            Booking booking = new Booking()
            {
                CheckInDate = vm.CheckInDate,
                CheckOutDate = vm.CheckOutDate,
                TotalPrice = vm.TotalPrice

            };
            return _bookingRepo.Create(booking);
        }


        public int Delete(int bookingID)
        {
            return _bookingRepo.Delete(_bookingRepo.GetByID(bookingID));
        }

        public List<BookingListVm> GetAll()
        {
            List<BookingListVm> bgList = new List<BookingListVm>();

            foreach (Booking booking in _bookingRepo.GetAll())
            {
                BookingListVm bgvm = new BookingListVm()
                {
                    ID = booking.Id,
                    CustomerId = booking.CustomerId,
                    RoomId = booking.RoomId,
                    CheckInDate = booking.CheckInDate,
                    CheckOutDate = booking.CheckOutDate,
                    TotalPrice = booking.TotalPrice,
                };
                bgList.Add(bgvm);
            }
            return bgList;
        }


        public int Update(BookingUpdateVm vm)
        {
            Booking booking = new Booking()
            {
                CheckInDate = vm.CheckInDate,
                CheckOutDate = vm.CheckOutDate,
                TotalPrice = vm.TotalPrice
            };
            return _bookingRepo.Update(booking);
        }

    }
}

