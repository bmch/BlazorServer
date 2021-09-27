using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace Notes.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Note> _notes; 

        public DbClient(IOptions<NoteDbConfig> noteDbConfig)
        {
            // create client, from db get collection
            var client = new MongoClient(noteDbConfig.Value.ConnectionString);
            var databse = client.GetDatabase(noteDbConfig.Value.DatabaseName);
            _notes = databse.GetCollection<Note>(noteDbConfig.Value.CollectionName);
        }

        public IMongoCollection<Note> GetNotesCollection() => _notes;

    }
    
}

