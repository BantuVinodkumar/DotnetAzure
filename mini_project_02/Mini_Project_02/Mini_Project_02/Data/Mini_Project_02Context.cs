using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mini_Project_02.Models;

namespace Mini_Project_02.Data
{
    public class Mini_Project_02Context : DbContext
    {
        public Mini_Project_02Context (DbContextOptions<Mini_Project_02Context> options)
            : base(options)
        {
        }

        public DbSet<Mini_Project_02.Models.Product>? Product { get; set; }
    }
}
