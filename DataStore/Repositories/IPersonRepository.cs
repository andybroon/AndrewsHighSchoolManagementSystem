using PersonDomain;

namespace DataStore.Repositories
{
    public interface IPersonRepository : IRepository<IPerson>
    {
        IPerson Get(string id);
    }
}
