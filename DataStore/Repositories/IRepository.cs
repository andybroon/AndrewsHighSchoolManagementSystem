using System;
using System.Collections.Generic;
using Utility;

namespace DataStore.Repositories
{
    public interface IRepository<T> : IDisposable
    {
        event EventHandler<EventArgs<IEnumerable<T>>> ItemsAdded;
        event EventHandler<EventArgs<IEnumerable<T>>> ItemsRemoved;
        event EventHandler Cleared;

        IEnumerable<T> GetAll();
        void Add(T item);
        void AddRange(IEnumerable<T> items);
        void Remove(T item);
        void RemoveRange(IEnumerable<T> items);
        void Clear();

    }
}