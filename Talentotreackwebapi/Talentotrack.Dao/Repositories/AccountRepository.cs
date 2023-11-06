using Azure.Core;
using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentotrack.common.DTOs.Account;
using Talentotrack.common.entities;
using Talentotrack.common.Repositories;
using Talentotrack.Dao.DB;

namespace Talentotrack.Dao.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public TalentotrackDbContext _dbContext;

        public AccountRepository(TalentotrackDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<LoginDetails>GetLoginDetails(string username, string password)
        {
            var dbrecord = await _dbContext.tbl_login_details.Where(p => p.username.Equals(username) && p.password.Equals(password)).FirstOrDefaultAsync();
            return dbrecord;
        }

    
    }  
}
