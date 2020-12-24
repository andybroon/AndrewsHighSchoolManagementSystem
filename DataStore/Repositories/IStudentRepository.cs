using System;
using System.Collections.Generic;
using PersonDomain.Students;
using Utility;

namespace DataStore.Repositories
{
    public interface IStudentRepository : IPersonRepository<IStudent>
    {
    }

    public class StudentRepository : IStudentRepository
    {
        public event EventHandler<EventArgs<IEnumerable<IStudent>>> ItemsAdded;
        public event EventHandler<EventArgs<IEnumerable<IStudent>>> ItemsRemoved;
        public event EventHandler Cleared;

        private readonly ISchoolContext _context;

        public StudentRepository(ISchoolContext context)
        {
            _context = context;
        }


        public IEnumerable<IStudent> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Add(IStudent item)
        {
            _context.Students.Add(item);
        }

        public void AddRange(IEnumerable<IStudent> items)
        {
            throw new NotImplementedException();
        }

        public void Remove(IStudent item)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<IStudent> items)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IStudent GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(IStudent person)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}