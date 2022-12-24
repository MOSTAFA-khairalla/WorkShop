using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entities;
using Web.Infrastrcture.Configuration;

namespace Web.Infrastrcture.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ):base( options )   
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EmployeeConfiguration.Configure(modelBuilder);

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
