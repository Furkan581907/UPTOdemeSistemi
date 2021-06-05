using System;
using System.Collections.Generic;
using System.Text;
using UPT.DataAccess.Contracts;
using UPT.DataAccess.DataContext;
using UPT.DataAccess.DbModels;

namespace UPT.DataAccess.Implementation
{
    public class PaymentsRepository:Repository<Payments>, IPaymentsRepository
    {
        private UPTContext _ctx;
        public PaymentsRepository(UPTContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
