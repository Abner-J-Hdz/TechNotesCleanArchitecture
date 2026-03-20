using System;

namespace TechNotes.Domain.Entities;

public class Notes
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Content { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? PublishedAt { get; set; }

    public bool IsPublished { get; set; }
}
