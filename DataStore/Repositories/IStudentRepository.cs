using PersonDomain.Students;

namespace DataStore.Repositories
{
    public interface IStudentRepository : IPersonRepository<IStudent>
    {
    }
}