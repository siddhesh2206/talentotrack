using Microsoft.AspNetCore.Mvc;
using Talentotrack.common.DTOs.Account;
using Talentotrack.common.services;

namespace Talentotreackwebapi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        public AccountController(ILogger<AccountController> logger,IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        //login web API
        [HttpPost(Name = "Login")]
        public async Task<LoginResponse> Login([FromBody] loginrequest request)
        {
            var response= await _accountService.VerifyLoginDetails(request);
           return response;
        }
    }
}