using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.BookingDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            return Ok(_bookingService.TGetListAll());
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDTO createBookingDTO)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDTO.Mail,
                DateTimeBooking = createBookingDTO.DateTimeBooking,
                Name = createBookingDTO.Name,
                PersonCount = createBookingDTO.PersonCount,
                Phone = createBookingDTO.Phone
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id) {
            var value =_bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDTO updateBookingDTO)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDTO.Mail,
                DateTimeBooking = updateBookingDTO.DateTimeBooking,
                Name = updateBookingDTO.Name,
                PersonCount = updateBookingDTO.PersonCount,
                Phone = updateBookingDTO.Phone

            };
            _bookingService.TUpdate(booking);
            return Ok("Güncellendi REzzervayon");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }

    }
}
