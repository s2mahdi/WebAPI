﻿using Common;
using Data.Contracts.Tickets;
using Entities;

namespace Data.Repositories.Tickets
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository, IScopedDependency
    {
        public TicketRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
