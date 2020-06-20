using Dynamics.Domain;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Service.Interfaces
{
    public interface IStoreManager : IRepository<Store>
    {
        void Complete();
    }
}
