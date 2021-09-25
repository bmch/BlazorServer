using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notes.Core;


namespace Note.WebApi.Blazor.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class NoteController : ControllerBase
    {
        private readonly INoteServices _noteServices;

        public NoteController(INoteServices noteServices)
        {
            _noteServices = noteServices;
        }

        [HttpGet]
        public IActionResult GetNotes()
        {
            return Ok(_noteServices.GetNotes());
        }

        [HttpGet("{id}", Name ="GetNote")]
        public IActionResult GetNotes(string id)
        {
            return Ok(_noteServices.GetNote(id));
        }

        [HttpPost]
        public IActionResult AddNote(Notes.Core.Note note)
        {
            _noteServices.AddNote(note);
            return CreatedAtRoute("GetNote", new { id = note.Id}, note);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(string id)
        {
            _noteServices.DeleteNote(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateNote(Notes.Core.Note note)
        {
            return Ok(_noteServices.UpdateNote(note));
           
        }
    }
}
