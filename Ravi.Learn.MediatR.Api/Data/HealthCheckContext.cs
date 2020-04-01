using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ravi.Learn.MediatR.Api.Data
{
    public class HealthCheckContext : DbContext
    {
        public HealthCheckContext(DbContextOptions<HealthCheckContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Person> People { get; set; }


    }
}
