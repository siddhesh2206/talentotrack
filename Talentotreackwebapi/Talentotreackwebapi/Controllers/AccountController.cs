using Microsoft.AspNetCore.Mvc;
using Talentotrack.common.DTOs.Account;

namespace Talentotreackwebapi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {

        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        //login web API
        [HttpPost(Name = "Login")]
        public LoginResponse Login([FromBody] loginrequest request)
        {
            var response= new LoginResponse();
           if (request.Username == "admin"&&request.Password=="1234") 
            {
            response.sucess=true;
            }
           else
            {
                response.sucess=false;
                response.Errormessage = "Invalid login";
            }
           return response;
        }
    }
}