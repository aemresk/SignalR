using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.TestimonialDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {

            var value = _mapper.Map<List<ResultTestimonialDTO>>(_testimonialService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDTO dto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Name = dto.Name,
                Title = dto.Title,
                Comment = dto.Comment,
                ImageURL    = dto.ImageURL,
                Status = true
            });

            return Ok("Testimonial Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Social Media Silindi");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDTO dto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Name = dto.Name,
                Title = dto.Title,
                Comment = dto.Comment,
                ImageURL = dto.ImageURL,
                Status = true
            });
            return Ok("Güncelleme işlemi yapıldı.");
        }
    }
}
