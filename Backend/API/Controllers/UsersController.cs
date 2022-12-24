using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _service;
        private IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _service = new UserManager();
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<UserDto>> GetAll()
        {
            return Ok(_service.GetAllUsers().Select(user=> _mapper.Map<UserDto>(user)));
        }

        [HttpGet("{id}")]
        public ActionResult<List<UserDto>> GetById(int id)
        {
            return Ok(_service.GetUserById(id).Select(user => _mapper.Map<UserDto>(user)));
        }

        [HttpPost]
        public ActionResult<UserDto> Post([FromBody] UserDto newUser) 
        {
            User user = _mapper.Map<User>(newUser);
            if(!ModelState.IsValid) 
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.CreateUser(user);
                return StatusCode(201, newUser);
            }
            
        }

        [HttpPut]
        public ActionResult<UserDto> Put([FromBody] UserDto newUser) 
        {
            User user = _mapper.Map<User>(newUser);
            
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            else
            {
                _service.UpdateUser(user);
                return StatusCode(200, newUser);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            try
            {
                _service.DeleteUser(id);
                return StatusCode(200);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
