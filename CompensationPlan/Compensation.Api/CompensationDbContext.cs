using Compensaction.Share;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compensation.Api
{
    public class CompensationDbContext:DbContext
    {

        public DbSet<FlatComision> FlatComision { get; set; }

        public CompensationDbContext(DbContextOptions<CompensationDbContext> options): base(options){}

    }
}
