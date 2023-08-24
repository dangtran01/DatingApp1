using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.Entities;
using Microsoft.EntityFrameworkCore;

namespace A.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}