using AutoMapper;
using Business.Abstract.ContentModels;
using Business.Concrete.ContentModels;
using DTO;
using DTO.ContentModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ContentModels;

namespace API.Controllers.ContentModels
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContentsController : ControllerBase
    {
        public IContentService _service;
        private IMapper _mapper;

        public ContentsController(IMapper mapper)
        {
            _service = new ContentManager();
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ContentDto>> GetAll()
        {
            return Ok(_service.GetAllContents().Select(content => _mapper.Map<ContentDto>(content)));
        }

        [HttpGet("{id}")]
        public ActionResult<List<ContentDto>> GetById(int id)
        {
            return Ok(_service.GetContentById(id).Select(content => _mapper.Map<ContentDto>(content)));
        }

        [HttpPost]
        public ActionResult<ContentDto> Post([FromBody] ContentDto newContent)
        {
            Content content = _mapper.Map<Content>(newContent);
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.CreateContent(content);
                return StatusCode(201, newContent);
            }

        }

        [HttpPut]
        public ActionResult<ContentDto> Put([FromBody] ContentDto newContent)
        {
            Content content = _mapper.Map<Content>(newContent);

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.UpdateContent(content);
                return StatusCode(200, newContent);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _service.DeleteContent(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
