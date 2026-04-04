using System;
using TechNotes.Application.Interfaces;
using TechNotes.Domain.Entities;
using TechNotes.Domain.Interfaces;

namespace TechNotes.Application.Services;

public class NoteService : INoteService
{
    private readonly INoteRepository _noteRepository;

	public NoteService(INoteRepository noteRepository)
	{
		_noteRepository = noteRepository;
	}

	public async Task<List<Notes>> GetAllNotesAsync()
    {
		return await _noteRepository.GetAllNotesAsync();
	}
}
