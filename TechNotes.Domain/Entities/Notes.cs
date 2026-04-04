using System;
using TechNotes.Domain.Abstractions;

namespace TechNotes.Domain.Entities;

public class Notes: Entity
{
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime? PublishedAt { get; set; }
    public bool IsPublished { get; set; }
}
