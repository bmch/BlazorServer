using System;
namespace Notes.Core
{
    public class NoteDbConfig:INoteDbConfig
    {
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
       
    }

    public interface INoteDbConfig
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
