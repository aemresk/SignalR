using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.CategoryDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {

            var value = _mapper.Map<List<ResultCategoryDTO>>(_categoryService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDTO.CategoryName,
                CategoryStatus = "true"
            });

            return Ok("KAtegor ieklendi");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("KAtegori Silindi");
        }

        [HttpGet]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryName = updateCategoryDTO.CategoryName,
                CategoryStatus = "false"

            });
            return Ok("Güncelleme işlemi yapıldı.");
        }
    }
}
