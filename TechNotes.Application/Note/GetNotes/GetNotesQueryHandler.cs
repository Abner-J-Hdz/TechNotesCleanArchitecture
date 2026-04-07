using MediatR;
using TechNotes.Domain.Entities;
using TechNotes.Domain.Interfaces;

namespace TechNotes.Application.Note.GetNotes;
public class GetNotesQueryHandler : IRequestHandler<GetNotesQuery, List<Notes>>
{
	private readonly INoteRepository _noteRepository;

	public GetNotesQueryHandler(INoteRepository noteRepository)
	{
		_noteRepository = noteRepository;
	}

	public async Task<List<Notes>> Handle(GetNotesQuery request, CancellationToken cancellationToken)
	{
		return await _noteRepository.GetAllNotesAsync();
	}
}
