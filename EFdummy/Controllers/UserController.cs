using EFdummy.DTO;
using EFdummy.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFdummy.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("AllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _userRepository.getAllUser());
        }
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(int userId,string userName,DateTime dob,int Did)
        {
            var user = new UserDTO
            {
                UserId = userId,
                UserName = userName,
                Dob = dob,
                DepartmentId = Did
            };
            var result = await _userRepository.AddUser(user);
            return Ok(result);
        }
        [HttpPut("UserUpadte")]
        public async Task<IActionResult> UpdateUser(int id,UserDTO userDTO)
        {
            var result = await _userRepository.UpdateUser(id,userDTO);
            return Ok(result);
        }
    }
}
