using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Work.Core.Domain.Entities;

namespace Work.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DataContext(DbContextOptions dbContext) : base(dbContext)
        {

        }


    }
}
