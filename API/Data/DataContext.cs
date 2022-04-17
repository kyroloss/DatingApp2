using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // you use this class to create the DB context in the start up class and passing some options 
        // during the dependency injection.
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users {get; set;}
    }
}