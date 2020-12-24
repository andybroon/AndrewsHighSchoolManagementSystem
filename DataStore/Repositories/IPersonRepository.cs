using PersonDomain;

namespace DataStore.Repositories
{
    public interface IPersonRepository<T> : IRepository<T> where T : IPerson
    {
        T GetById(string id);
        void Update(T person);
    }
}
