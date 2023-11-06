using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentotrack.common.entities;

namespace Talentotrack.common.Repositories
{
    public interface IAccountRepository
    {
        Task<LoginDetails>GetLoginDetails(string username, string password);
    }
}
