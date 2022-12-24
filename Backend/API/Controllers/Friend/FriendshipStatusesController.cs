using AutoMapper;
using Business.Abstract.Friend;
using Business.Concrete.Friend;
using DTO;
using DTO.Friend;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Friend;

namespace API.Controllers.Friend
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendshipStatusesController : ControllerBase
    {
        private IFriendshipStatusService _service;
        private IMapper _mapper;

        public FriendshipStatusesController(IMapper mapper)
        {
            _service = new FriendshipStatusManager();
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<FriendshipStatusDto>> GetAll()
        {
            return Ok(_service.GetFriendshipStatuses().Select(status => _mapper.Map<FriendshipStatusDto>(status)));
        }

        [HttpGet("{id}")]
        public ActionResult<List<FriendshipStatusDto>> GetById(int id)
        {
            return Ok(_service.GetFriendshipStatusById(id).Select(status => _mapper.Map<FriendshipStatusDto>(status)));
        }

        [HttpPost]
        public ActionResult<FriendshipStatusDto> Post([FromBody] FriendshipStatusDto newStatus)
        {
            FriendshipStatus status = _mapper.Map<FriendshipStatus>(newStatus);

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.CreateFriendshipStatus(status);
                return StatusCode(201, newStatus);
            }

        }

        [HttpPut]
        public ActionResult<FriendshipStatusDto> Put([FromBody] FriendshipStatusDto newStatus)
        {
            FriendshipStatus status = _mapper.Map<FriendshipStatus>(newStatus);

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.UpdateFriendshipStatus(status);
                return StatusCode(200, newStatus);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _service.DeleteFriendshipStatus(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
