using BodegaVinos.Models;
using BodegaVinos.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BodegaVinos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserDTO dto)
        {
            User newUser = new User()
            {
                Id = _userRepository.Users.Max(x => x.Id) + 1,
                Username = dto.UserName,
                Password = dto.Password
            };

            _userRepository.Users.Add(newUser);

            return Ok(newUser);
        }
    }
}
