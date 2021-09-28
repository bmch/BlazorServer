using System;
using System.Collections.Generic;

namespace Notes.Core
{
    public interface INoteServices
    {
        List<Note> GetNotes();
        Note AddNote(Note note);
        Note GetNote(string id);
        void DeleteNote(string id);
        Note UpdateNote(Note note);
        Note CheckReference(string reference);

    }
}
