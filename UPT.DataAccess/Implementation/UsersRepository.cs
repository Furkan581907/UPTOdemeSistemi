using System;
using System.Collections.Generic;
using System.Text;
using UPT.DataAccess.Contracts;
using UPT.DataAccess.DataContext;
using UPT.DataAccess.DbModels;

namespace UPT.DataAccess.Implementation
{
    public class UsersRepository:Repository<Users>, IUsersRepository
    {
        private UPTContext _ctx;
        public UsersRepository(UPTContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
