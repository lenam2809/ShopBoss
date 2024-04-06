using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserManager<User> userManager, IMapper mapper) : ControllerBase
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly IMapper _mapper = mapper;

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            var users = _userManager.Users;
            var userDtos = _mapper.Map<IEnumerable<UserDTO>>(users);
            return Ok(userDtos);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<UserDTO>(user);
            return Ok(userDto);
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            return CreatedAtAction(nameof(Get), new { id = userDto.Id }, userDto);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UserDTO userDto)
        {
            if (id != userDto.Id)
            {
                return BadRequest();
            }

            var existingUser = await _userManager.FindByIdAsync(id.ToString());
            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.UserName = userDto.UserName;
            existingUser.Email = userDto.Email;
            existingUser.FullName = userDto.FullName;
            existingUser.Address = userDto.Address;

            var result = await _userManager.UpdateAsync(existingUser);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }
    }
}
