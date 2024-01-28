using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
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
        public IActionResult GetTestimonialList()
        {
            var result = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetAllList());
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Name = createTestimonialDto.Name,
                Comment = createTestimonialDto.Comment,
                ImageUrl = createTestimonialDto.ImageUrl,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title,
            });
            return Ok("Müşteri değerlendirme bilgisi başarıyla eklendi!");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var result = _testimonialService.TGetById(id);
            _testimonialService.TDelete(result);
            return Ok("Müşteri değerlendirme bilgisi başarıyla silindi!");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonialById(int id)
        {
            var result = _testimonialService.TGetById(id);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Name = updateTestimonialDto.Name,
                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title,
                TestimonialId = updateTestimonialDto.TestimonialId
            });
            return Ok("Müşteri değerlendirme bilgisi başarılı bir şekilde güncellendi");
        }
    }
}
