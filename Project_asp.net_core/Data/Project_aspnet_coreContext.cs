using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_asp.net_core.Models;

namespace Project_asp.net_core.Data
{
    public class Project_aspnet_coreContext : DbContext
    {
        public Project_aspnet_coreContext (DbContextOptions<Project_aspnet_coreContext> options)
            : base(options)
        {
        }

        public DbSet<Project_asp.net_core.Models.Category> Category { get; set; }

        public DbSet<Project_asp.net_core.Models.Product> Product { get; set; }

        public DbSet<Project_asp.net_core.Models.User> User { get; set; }
    }
}
