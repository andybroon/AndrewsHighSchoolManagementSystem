using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace DataStore.Repositories
{
    public interface IRepository<T> : IObservable<T>, IQueryable<T>
    {
        event EventHandler<EventArgs<IEnumerable<T>>> ItemsAdded;
        event EventHandler<EventArgs<IEnumerable<T>>> ItemsRemoved;
        event EventHandler Cleared;
        void Add(T item);
        void AddRange(IEnumerable<T> items);
        void Remove(T item);
        void RemoveRange(IEnumerable<T> items);
        void Clear();
    }
}