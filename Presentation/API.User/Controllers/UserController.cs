using Domain.User;
using Domain.User.Models;
using Microsoft.AspNetCore.Mvc;
using API.User.Models;
using System.Threading.Tasks;

namespace API.User.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserFacade _userFacade;

        public UserController(IUserFacade userFacade)
        {
            _userFacade = userFacade;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] AddUserRequest addUserRequest)
        {
            var addUserCommand = new AddUserCommand(addUserRequest.first_name, addUserRequest.last_name, addUserRequest.email, addUserRequest.gsm_no);
            var userEntity = await _userFacade.AddUserAsync(addUserCommand);
            var response = new AddUserResponse()
            {
                id = userEntity.ID,
                first_name = userEntity.FirstName,
                last_name = userEntity.LastName,
                email = userEntity.Email,
                gsm_no = userEntity.GsmNo
            };

            return Ok(response);
        }
    }
}
