using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
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
        public IActionResult GetProductList()
        {
            var result = _mapper.Map<List<ResultProductDto>>(_productService.TGetAllList());
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus,
            });
            return Ok("Ürün bilgisi başarılı bir şekilde eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var result = _productService.TGetById(id);
            _productService.TDelete(result);
            return Ok("Ürün bilgisi başarılı bir şekilde eklendi");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProductById(int id)
        {
            var result = _productService.TGetById(id);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                ProductId = updateProductDto.ProductId
            });
            return Ok("Ürün bilgisi başarılı bir şekilde güncellendi!");
        }
    }
}
