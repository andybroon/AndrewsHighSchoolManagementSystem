﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataStore.DataAccess;
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
        }

        public void AddRange(IEnumerable<IStudent> items)
        {
            foreach (var student in items)
                _context.Students.Add(student);
        }

        public void Remove(IStudent item)
        {
            _context.Students.Remove(item);
        }

        public void RemoveRange(IEnumerable<IStudent> items)
        {
            foreach (var student in items)
                _context.Students.Remove(student);
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