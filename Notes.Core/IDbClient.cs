using MongoDB.Driver;

namespace Notes.Core
{
    public interface IDbClient
    {
        IMongoCollection<Note> GetNotesCollection();
    }
}
