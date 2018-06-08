using System.Collections.Generic;

namespace DatabaseTest
{
    public interface IDatabase : IEnumerable<IRepository>
    {
        string Name { get; }
        IRepository GetRepository(string name);
        IRepository<TModel> GetRepository<TModel>() where TModel : IModel;
        IRepository<TModel> GetRepository<TModel>(string name) where TModel : IModel;
    }
}