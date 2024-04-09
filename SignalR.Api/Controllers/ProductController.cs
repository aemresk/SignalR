using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.FeatureDTO;
using SignalR.DTOLayer.ProductDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {

            var value = _mapper.Map<List<ResultProductDTO>>(_productService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDTO dto)
        {
            _productService.TAdd(new Product()
            {
                ProductName = dto.ProductName,
                Description = dto.Description,
                Price = dto.Price,
                ImageURL = dto.ImageURL,
                ProductStatus = true
            });

            return Ok("Product Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("product Silindi");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDTO dto)
        {
            _productService.TUpdate(new Product()
            {
                ProductName = dto.ProductName,
                Description = dto.Description,
                Price = dto.Price,
                ImageURL = dto.ImageURL,
                ProductStatus = true
            });
            return Ok("Güncelleme işlemi yapıldı.");
        }
    }
}
