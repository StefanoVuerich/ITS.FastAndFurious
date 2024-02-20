using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITS.FastAndFurious.Models;

namespace ITS.FastAndFurious.Data
{
    public class ITSFastAndFuriousContext : DbContext
    {
        public ITSFastAndFuriousContext (DbContextOptions<ITSFastAndFuriousContext> options)
            : base(options)
        {
        }

        public DbSet<ITS.FastAndFurious.Models.Product> Product { get; set; } = default!;
        public DbSet<ITS.FastAndFurious.Models.Supplier> Supplier { get; set; } = default!;
    }
}
