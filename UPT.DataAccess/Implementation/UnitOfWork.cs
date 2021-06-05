using System;
using System.Collections.Generic;
using System.Text;
using UPT.DataAccess.Contracts;
using UPT.DataAccess.DataContext;

namespace UPT.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private UPTContext _ctx;
        public UnitOfWork(UPTContext ctx)
        {
            _ctx = ctx;
            UPTUsers = new UsersRepository(_ctx);
            UPTDebts = new DebtsRepository(_ctx);
            UPTDeposits = new DepositsRepository(_ctx);
            UPTSubscriptions = new SubscriptionsRepository(_ctx);
            UPTPayments = new PaymentsRepository(_ctx);
        }
        public IUsersRepository UPTUsers { get; private set; }
        public IDebtsRepository UPTDebts { get; private set; }
        public IDepositsRepository UPTDeposits { get; private set; }
        public ISubscriptionsRepository UPTSubscriptions { get; private set; }
        public IPaymentsRepository UPTPayments { get; private set; }

        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
