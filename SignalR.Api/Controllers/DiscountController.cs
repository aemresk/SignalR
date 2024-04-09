using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ContactDTO;
using SignalR.DTOLayer.DiscountDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {

            var value = _mapper.Map<List<ResultDiscountDTO>>(_discountService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateContact(CreateDiscountDTO dto)
        {
            _discountService.TAdd(new Discount()
            {
               Amount= dto.Amount,
               Description= dto.Description,
               ImageURL= dto.ImageURL,
               Title= dto.Title
            });

            return Ok("indirim eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteDiscoubt(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("indirim Silindi");
        }

        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateDiscountDTO updateDiscount)
        {
            _discountService.TUpdate(new Discount()
            {
                Amount = updateDiscount.Amount,
                Description = updateDiscount.Description,
                ImageURL = updateDiscount.ImageURL,
                Title = updateDiscount.Title

            });
            return Ok("Güncelleme işlemi yapıldı.");
        }

    }
}
