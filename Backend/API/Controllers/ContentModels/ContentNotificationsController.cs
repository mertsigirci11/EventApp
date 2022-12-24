using AutoMapper;
using Business.Abstract;
using Business.Abstract.ContentModels;
using Business.Concrete.ContentModels;
using DTO;
using DTO.ContentModels;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ContentModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers.ContentModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentNotificationsController : ControllerBase
    {
        private IContentNotificationService _service;
        private IMapper _mapper;

        public ContentNotificationsController(IMapper mapper)
        {
            _service = new ContentNotificationManager();
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ContentNotificationDto>> GetAll()
        {
            return Ok(_service.GetAllContentNotifications().Select(contentNotification => _mapper.Map<ContentNotificationDto>(contentNotification)));
        }

        [HttpGet("{id}")]
        public ActionResult<List<ContentNotificationDto>> GetById(int id)
        {
            return Ok(_service.GetContentNotificationById(id).Select(contentNotification => _mapper.Map<ContentNotificationDto>(contentNotification)));
        }

        [HttpPost]
        public ActionResult<ContentNotificationDto> Post([FromBody] ContentNotificationDto newContentNotification)
        {
            ContentNotification contentNotification = _mapper.Map<ContentNotification>(newContentNotification);
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.CreateContentNotification(contentNotification);
                return StatusCode(201, newContentNotification);
            }

        }

        [HttpPut]
        public ActionResult<ContentNotificationDto> Put([FromBody] ContentNotificationDto newContentNotification)
        {
            ContentNotification contentNotification = _mapper.Map<ContentNotification>(newContentNotification);

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.UpdateContentNotification(contentNotification);
                return StatusCode(200, newContentNotification);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _service.DeleteContentNotification(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
