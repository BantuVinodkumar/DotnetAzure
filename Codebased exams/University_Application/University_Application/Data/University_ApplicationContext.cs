using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using University_Application.Models;

namespace University_Application.Data
{
    public class University_ApplicationContext : DbContext
    {
        public University_ApplicationContext (DbContextOptions<University_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<University_Application.Models.Student>? Student { get; set; }
    }
}
