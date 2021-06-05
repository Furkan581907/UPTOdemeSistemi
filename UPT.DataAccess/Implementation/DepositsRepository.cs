using System;
using System.Collections.Generic;
using System.Text;
using UPT.DataAccess.Contracts;
using UPT.DataAccess.DataContext;
using UPT.DataAccess.DbModels;

namespace UPT.DataAccess.Implementation
{
    public class DepositsRepository:Repository<Deposits>, IDepositsRepository
    {
        private UPTContext _ctx;
        public DepositsRepository(UPTContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
