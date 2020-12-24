using System;
using DataStore.Repositories;

namespace DataStore
{
    public interface IUnitOfWork : IDisposable
    {
        ITeacherRepository TeacherRepository { get; }
        IStudentRepository StudentRepository { get; }
    }
}
