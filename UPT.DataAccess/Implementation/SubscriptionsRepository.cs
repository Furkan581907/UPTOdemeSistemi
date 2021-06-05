using System;
using System.Collections.Generic;
using System.Text;
using UPT.DataAccess.Contracts;
using UPT.DataAccess.DataContext;
using UPT.DataAccess.DbModels;

namespace UPT.DataAccess.Implementation
{
    public class SubscriptionsRepository : Repository<Subscriptions>, ISubscriptionsRepository
    {
        private UPTContext _ctx;
        public SubscriptionsRepository(UPTContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
