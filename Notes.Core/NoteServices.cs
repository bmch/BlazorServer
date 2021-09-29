﻿using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Notes.Core
{
    public class NoteServices : INoteServices
    {
        private readonly IMongoCollection<Note> _notes;

        // public NoteServices(IDbClient dbClient)
        // {
        //    _notes =  dbClient.GetNotesCollection();
        // }

         public NoteServices(INoteDbConfig settings)
        {
           // var client = new MongoClient(settings.ConnectionString);
            var client = new MongoClient(Environment.GetEnvironmentVariable("Custom"));
             var database = client.GetDatabase(settings.DatabaseName);

            _notes = database.GetCollection<Note>(settings.CollectionName);
        }

        public Note AddNote(Note note)
        {
            _notes.InsertOne(note);
            return note;
        }

        public void DeleteNote(string id) => _notes.DeleteOne(note => note.Id == id);
         

        public Note GetNote(string id) => _notes.Find(note => note.Id == id).First();
        public Note CheckReference(string reference) => _notes.Find(note => note.Reference == reference).FirstOrDefault();
        

        public List<Note> GetNotes() => _notes.Find(Note => true).ToList();

        public Note UpdateNote(Note note)
        {
            GetNote(note.Id);
            _notes.ReplaceOne(n => n.Id == note.Id,note);
            return note;
        }
    }
}
