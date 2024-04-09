using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ProductDTO;
using SignalR.DTOLayer.SocialMediaDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {

            var value = _mapper.Map<List<ResultSocialMediaDTO>>(_socialMediaService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDTO dto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Title= dto.Title,
                URL= dto.URL,
                Icon    = dto.Icon
            });

            return Ok("Product Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Social Media Silindi");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDTO dto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Title = dto.Title,
                URL = dto.URL,
                Icon = dto.Icon
            });
            return Ok("Güncelleme işlemi yapıldı.");
        }
    }
}
