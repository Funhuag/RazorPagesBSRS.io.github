using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBSRS.Model;

namespace RazorPagesBSRS.Data
{
    public class RazorPagesBSRSContext : DbContext
    {
        public RazorPagesBSRSContext (DbContextOptions<RazorPagesBSRSContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBSRS.Model.BSRS> BSRS { get; set; } = default!;
    }
}
