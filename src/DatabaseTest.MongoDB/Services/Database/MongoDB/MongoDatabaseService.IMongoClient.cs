using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Clusters;

namespace DatabaseTest.Services.Database.MongoDB
{
    internal partial class MongoDatabaseService : IMongoClient
    {
        public ICluster Cluster => MongoClient.Cluster;

        public MongoClientSettings Settings => MongoClient.Settings;

        public void DropDatabase(string name, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.DropDatabase(name, cancellationToken);

        public void DropDatabase(IClientSessionHandle session, string name, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.DropDatabase(session, name, cancellationToken);

        public Task DropDatabaseAsync(string name, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.DropDatabaseAsync(name, cancellationToken);

        public Task DropDatabaseAsync(IClientSessionHandle session, string name, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.DropDatabaseAsync(session, name, cancellationToken);

        public IMongoDatabase GetDatabase(string name, MongoDatabaseSettings settings = null) => MongoClient.GetDatabase(name, settings);

        public IAsyncCursor<BsonDocument> ListDatabases(CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.ListDatabases(cancellationToken);

        public IAsyncCursor<BsonDocument> ListDatabases(IClientSessionHandle session, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.ListDatabases(session, cancellationToken);

        public Task<IAsyncCursor<BsonDocument>> ListDatabasesAsync(CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.ListDatabasesAsync(cancellationToken);

        public Task<IAsyncCursor<BsonDocument>> ListDatabasesAsync(IClientSessionHandle session, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.ListDatabasesAsync(session, cancellationToken);

        public IClientSessionHandle StartSession(ClientSessionOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.StartSession(options, cancellationToken);

        public Task<IClientSessionHandle> StartSessionAsync(ClientSessionOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) => MongoClient.StartSessionAsync(options, cancellationToken);

        public IMongoClient WithReadConcern(ReadConcern readConcern) => MongoClient.WithReadConcern(readConcern);

        public IMongoClient WithReadPreference(ReadPreference readPreference) => MongoClient.WithReadPreference(readPreference);

        public IMongoClient WithWriteConcern(WriteConcern writeConcern) => MongoClient.WithWriteConcern(writeConcern);
    }
}