namespace DatabaseTest
{
    public interface IRepository
    {
        string Name { get; }
        IDatabase Database { get; }
        IRepository<TModel> As<TModel>() where TModel : ModelBase;
    }
}