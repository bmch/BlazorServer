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
            var client = new MongoClient(noteDbConfig.Value.Connection_String);
            var databse = client.GetDatabase(noteDbConfig.Value.Database_Name);
            _notes = databse.GetCollection<Note>(noteDbConfig.Value.Note_Collection_Name);
        }

        public IMongoCollection<Note> GetNotesCollection() => _notes;

    }
    
}
