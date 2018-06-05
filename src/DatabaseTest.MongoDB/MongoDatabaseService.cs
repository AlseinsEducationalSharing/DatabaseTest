using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace DatabaseTest.MongoDB
{
    internal partial class MongoDatabaseService
    {
        public IMongoClient MongoClient { get; set; }

        private IEnumerable<IDatabase> databases => MongoClient.ListDatabases().ToEnumerable().Select(data => this[data["name"].ToString()]);

        public override bool Equals(object obj) => obj is MongoDatabaseService service && MongoClient == service.MongoClient;

        public override int GetHashCode() => base.GetHashCode();
    }
}