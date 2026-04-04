

using TechNotes.Domain.Entities;

namespace TechNotes.Domain.Interfaces;
public interface INoteRepository
{
	Task<List<Notes>> GetAllNotesAsync();
}
