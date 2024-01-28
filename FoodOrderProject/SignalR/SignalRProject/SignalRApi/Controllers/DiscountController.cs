using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SignalRApi.Controllers
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
            var result = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetAllList());
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Title = createDiscountDto.Title,
                ImageUrl = createDiscountDto.ImageUrl,
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
            });
            return Ok("İndirim başarılı bir şekilde eklendi!");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim bilgisi başarılı bir şekilde silindi!");
        }
        [HttpGet("GetDiscount")]
        public IActionResult GetDiscountById(int id) 
        {
            var value = _discountService.TGetById(id);
            return Ok(value);   
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                DiscountId = updateDiscountDto.DiscountId,
                ImageUrl = updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title,
            });
            return Ok("İndirim bilgisi başarılı bir şekilde güncellendi!");
        }
    }
}
