using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentotrack.common.DTOs.Account;

namespace Talentotrack.common.services
{
    public interface IAccountService
    {
        Task<LoginResponse> VerifyLoginDetails(loginrequest request);

    }
}
