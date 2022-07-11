using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBasedEvaluation_06.Models;

namespace CodeBasedEvaluation_06.Data
{
    public class CodeBasedEvaluation_06Context : DbContext
    {
        public CodeBasedEvaluation_06Context (DbContextOptions<CodeBasedEvaluation_06Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBasedEvaluation_06.Models.Employee>? Employee { get; set; }
    }
}
