using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DatabaseTest
{
    public interface IRepository<TModel> : IRepository, IQueryable<TModel>, ICollection<TModel> where TModel : ModelBase
    {
        TModel this[string id] { get; set; }
        void Add(IEnumerable<TModel> items);
        int Remove(Expression<Func<TModel, bool>> predicate);
        bool Update(TModel item);
        int Update(IEnumerable<TModel> items);
        int Update(Expression<Func<TModel, bool>> predicate, TModel item);

    }
}