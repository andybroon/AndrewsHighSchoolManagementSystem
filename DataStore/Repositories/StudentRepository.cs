using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DataStore.DataAccess;
using PersonDomain.Students;
using Utility;

namespace DataStore.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public event EventHandler<EventArgs<IEnumerable<IStudent>>> ItemsAdded;
        public event EventHandler<EventArgs<IEnumerable<IStudent>>> ItemsRemoved;

        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
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
            OnItemsAdded(new EventArgs<IEnumerable<IStudent>>(new []{item}));
        }

        public void AddRange(IEnumerable<IStudent> items)
        {
            var students = items as IStudent[] ?? items.ToArray();
            foreach (var student in students)
                _context.Students.Add(student);
            OnItemsAdded(new EventArgs<IEnumerable<IStudent>>(students));
        }

        public void Remove(IStudent item)
        {
            _context.Students.Remove(item);
            OnItemsRemoved(new EventArgs<IEnumerable<IStudent>>(new []{item}));
        }

        public void RemoveRange(IEnumerable<IStudent> items)
        {
            var students = items as IStudent[] ?? items.ToArray();
            foreach (var student in students)
                _context.Students.Remove(student);
            OnItemsRemoved(new EventArgs<IEnumerable<IStudent>>(students));
        }

        public IStudent GetById(string id)
        {
            return _context.Students.SingleOrDefault(x => x.Id.Equals(id));
        }

        public void Update(IStudent person)
        {
            _context.Students.AddOrUpdate(person);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        protected virtual void OnItemsAdded(EventArgs<IEnumerable<IStudent>> e)
        {
            ItemsAdded?.Invoke(this, e);
        }

        protected virtual void OnItemsRemoved(EventArgs<IEnumerable<IStudent>> e)
        {
            ItemsRemoved?.Invoke(this, e);
        }
    }
}