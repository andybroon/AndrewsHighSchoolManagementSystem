namespace DataStore
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}