using System;
using DataStore.Repositories;

namespace DataStore
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository PersonRepository { get; }
    }
}
