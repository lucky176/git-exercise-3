using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using core_mvc_git_exercise.model;

namespace core_mvc_git_exercise.Data
{
    public class coreDbContext : DbContext
    {
        public coreDbContext (DbContextOptions<coreDbContext> options)
            : base(options)
        {
        }

        public DbSet<core_mvc_git_exercise.model.Player> Player { get; set; }
    }
}
