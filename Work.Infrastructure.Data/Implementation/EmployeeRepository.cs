using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Work.Core.Application.Interfaces;
using Work.Core.Domain.Entities;

namespace Work.Infrastructure.Data.Implementation
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly DataContext context;
        public EmployeeRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetWithPosition()
        {
            return context.Employees.Include(x => x.Position);
        }

        public Employee GetWithPositionById(int id)
        {
            return context.Employees
                .Include(x => x.Position)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
