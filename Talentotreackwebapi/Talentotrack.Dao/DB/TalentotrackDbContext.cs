using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentotrack.Dao.entities;

namespace Talentotrack.Dao.DB
{
    public class TalentotrackDbContext:DbContext
    {
        public DbSet<User> tbl_user { get; set; }

        public TalentotrackDbContext(DbContextOptions<TalentotrackDbContext> options)
            : base(options) { }
            
    }
}
