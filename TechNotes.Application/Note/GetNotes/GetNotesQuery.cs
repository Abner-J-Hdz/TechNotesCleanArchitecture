using MediatR;
using TechNotes.Domain.Entities;

namespace TechNotes.Application.Note.GetNotes;
public class GetNotesQuery: IRequest<List<Notes>>
{

}
