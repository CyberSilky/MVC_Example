using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Example.Models
{
    public class MVC_ExampleContext : DbContext
    {
        public MVC_ExampleContext (DbContextOptions<MVC_ExampleContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Example.Models.Product> Product { get; set; }
    }
}
