using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
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
        public IActionResult GetSocialMediaList() 
        {
            var result = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetAllList());
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Icon = createSocialMediaDto.Icon,
                Title = createSocialMediaDto.Title,
                Url = createSocialMediaDto.Url,
            });
            return Ok("Sosyal Medya bilgisi başarılı bir şekilde eklendi!");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var result = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(result);
            return Ok("Sosyal Medya bilgisi başarılı bir şekilde silindi!");
        }
        [HttpGet("GetSocialMedya")]
        public IActionResult GetSocialMediaById(int id) 
        {
            var result = _socialMediaService.TGetById(id);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedya(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Icon = updateSocialMediaDto.Icon,
                SocialMediaId = updateSocialMediaDto.SocialMediaId,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url,
            });
            return Ok("Sosyal medya bilgisi başarılı bir şekilde güncellendi!");
        }
    }
}
