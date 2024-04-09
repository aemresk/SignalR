using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.CategoryDTO;
using SignalR.DTOLayer.FeatureDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }




        [HttpGet]
        public IActionResult FeatureList()
        {

            var value = _mapper.Map<List<ResultFeatureDTO>>(_featureService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDTO dto)
        {
            _featureService.TAdd(new Feature()
            {
                Title1 = dto.Title1,
                Description1 = dto.Description1,
                Title2= dto.Title2,
                Description2 = dto.Description2,
                Title3 = dto.Title3,
                Description3 = dto.Description3
            });

            return Ok("FEature Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("feature Silindi");
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDTO dto)
        {
            _featureService.TUpdate(new Feature()
            {
                Title1 = dto.Title1,
                Description1 = dto.Description1,
                Title2 = dto.Title2,
                Description2 = dto.Description2,
                Title3 = dto.Title3,
                Description3 = dto.Description3
            });
            return Ok("Güncelleme işlemi yapıldı.");
        }
    }
}
