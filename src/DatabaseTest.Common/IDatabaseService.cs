using System.Collections.Generic;

namespace DatabaseTest
{
    public interface IDatabaseService : IEnumerable<IDatabase>
    {
        IDatabase this[string name] { get; }
    }
}