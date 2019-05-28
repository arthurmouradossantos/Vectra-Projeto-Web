using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Original.Models
{
    public class OriginalContext : DbContext
    {
        public OriginalContext (DbContextOptions<OriginalContext> options)
            : base(options)
        {
        }

        public DbSet<Original.Models.Toregister> Toregister { get; set; }
    }
}
