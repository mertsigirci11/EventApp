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
    public class FriendshipsController : ControllerBase
    {
        private IFriendshipService _service;
        private IMapper _mapper;

        public FriendshipsController(IMapper mapper)
        {
            _service = new FriendshipManager();
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<FriendshipDto>> GetAll()
        {
            return Ok(_service.GetFriendships().Select(friendship => _mapper.Map<FriendshipDto>(friendship)));
        }

        [HttpGet("{id}")]
        public ActionResult<List<FriendshipDto>> GetById(int id)
        {
            return Ok(_service.GetFriendshipById(id).Select(friendship => _mapper.Map<FriendshipDto>(friendship)));
        }

        [HttpPost]
        public ActionResult<FriendshipDto> Post([FromBody] FriendshipDto newFriendship)
        {
            Friendship friendship = _mapper.Map<Friendship>(newFriendship);
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.CreateFriendship(friendship);
                return StatusCode(201, newFriendship);
            }

        }

        [HttpPut]
        public ActionResult<FriendshipDto> Put([FromBody] FriendshipDto newFriendship)
        {
            Friendship friendship = _mapper.Map<Friendship>(newFriendship);

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.UpdateFriendship(friendship);
                return StatusCode(200,  newFriendship);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _service.DeleteFriendship(id);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
