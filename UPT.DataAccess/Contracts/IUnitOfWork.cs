using System;
using System.Collections.Generic;
using System.Text;

namespace UPT.DataAccess.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
    }
}
