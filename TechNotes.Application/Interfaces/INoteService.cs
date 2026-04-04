
using TechNotes.Domain.Entities;

namespace TechNotes.Application.Interfaces;

public interface INoteService
{
    Task<List<Notes>> GetAllNotesAsync();
}
