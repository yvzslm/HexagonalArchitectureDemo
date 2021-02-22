using Domain.User;
using Domain.User.Models;
using Microsoft.AspNetCore.Mvc;
using API.User.Models;

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
        public IActionResult AddUser([FromBody] AddUserRequest addUserRequest)
        {
            var addUser = new AddUser(addUserRequest.first_name, addUserRequest.last_name, addUserRequest.email, addUserRequest.gsm_no);
            var userEntity = _userFacade.AddUser(addUser);
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

        [HttpPost("send_mail")]
        public IActionResult SendMail([FromBody] SendMailRequest sendMailRequest)
        {
            var sendMail = new SendMail(sendMailRequest.email_to, sendMailRequest.subject, sendMailRequest.body);
            var result = _userFacade.SendMail(sendMail);
            var response = new Response()
            {
                status_code = result.ResultCode,
                message = result.Message
            };

            return Ok(response);
        }

        [HttpPost("send_sms")]
        public IActionResult SendSms([FromBody] SendSmsRequest sendSmsRequest)
        {
            var sendSms = new SendSms(sendSmsRequest.GsmNo, sendSmsRequest.Message);
            var result = _userFacade.SendSms(sendSms);
            var response = new Response()
            {
                status_code = result.ResultCode,
                message = result.Message
            };

            return Ok(response);
        }
    }
}
