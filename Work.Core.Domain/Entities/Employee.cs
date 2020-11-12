using System;
using System.Collections.Generic;
using System.Text;

namespace Work.Core.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
    }
}
