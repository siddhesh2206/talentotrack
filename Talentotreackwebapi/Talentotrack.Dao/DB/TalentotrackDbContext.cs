﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentotrack.common.entities;

namespace Talentotrack.Dao.DB
{
    public class TalentotrackDbContext : DbContext
    {
        public DbSet<User> tbl_user { get; set; }
        public DbSet<LoginDetails> tbl_login_details {  get; set; }

        public TalentotrackDbContext(DbContextOptions<TalentotrackDbContext> options)
            : base(options) { }
            
    }
}
