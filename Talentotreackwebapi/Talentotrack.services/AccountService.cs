using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentotrack.common.DTOs.Account;
using Talentotrack.common.Repositories;
using Talentotrack.common.services;

namespace Talentotrack.services
{
    public class AccountService : IAccountService
    {
        public readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<LoginResponse> VerifyLoginDetails(loginrequest request)
        {
        LoginResponse response = new LoginResponse();
        try{

        var dbuser=await _accountRepository.GetLoginDetails(request.Username, request.Password);
                if (dbuser == null)
                {
                    response.sucess = false;
                    response.Errormessage = "Invalid Credintials";
                }
                else
                {
                    response.sucess = true;
                }
                return response;
    }
        catch(Exception ex){
        throw;
        
        }

}

    }
}
