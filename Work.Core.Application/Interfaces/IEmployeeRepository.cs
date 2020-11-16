using System;
using System.Collections.Generic;
using System.Text;
using Work.Core.Domain.Entities;

namespace Work.Core.Application.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetWithPosition();
        Employee GetWithPositionById(int id);
    }
}
