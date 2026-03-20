using System;
using TechNotes.Application.Interfaces;
using TechNotes.Domain.Entities;

namespace TechNotes.Application.Services;

public class NoteService : INoteService
{
    public List<Notes> GetAllNotes()
    {
        return new List<Notes>
        {
            new Notes
            {
                Id = 1,
                Title = "First Note",
                Content = "This is the content of the first note.",
                CreatedAt = DateTime.UtcNow,
                IsPublished = true,
                PublishedAt = DateTime.UtcNow
            },  
            new Notes
            {
                Id = 2,
                Title = "Second Note",
                Content = "This is the content of the second note.",
                CreatedAt = DateTime.UtcNow,
                IsPublished = false,
                PublishedAt = null
            }
        };
    }
}
