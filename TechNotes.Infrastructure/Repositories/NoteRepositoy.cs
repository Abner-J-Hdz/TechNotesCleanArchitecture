using Microsoft.EntityFrameworkCore;
using TechNotes.Domain.Entities;
using TechNotes.Domain.Interfaces;

namespace TechNotes.Infrastructure.Repositories;
public class NoteRepositoy : INoteRepository
{
	private readonly ApplicationDbContext _context;

	public NoteRepositoy(ApplicationDbContext contex)
	{
		_context = contex;
	}

	public async Task<List<Notes>> GetAllNotesAsync()
	{
		return await _context.Notes.ToListAsync();
	}
}
