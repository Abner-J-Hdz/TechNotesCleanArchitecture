
using TechNotes.Domain.Entities;

namespace TechNotes.Application.Interfaces;

public interface INoteService
{
    List<Notes> GetAllNotes();
}
