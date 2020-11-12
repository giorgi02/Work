using System;
using System.Collections.Generic;
using System.Text;
using Work.Core.Application.Interfaces;
using Work.Core.Domain.Entities;

namespace Work.Infrastructure.Data.Implementation
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        private readonly DataContext context;
        public PositionRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
