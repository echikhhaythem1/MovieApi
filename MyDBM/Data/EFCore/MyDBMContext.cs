using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyDBM.Models
{
    public class MyDBMContext : DbContext
    {
        public MyDBMContext (DbContextOptions<MyDBMContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Star> Stars { get; set; }
    }
}
