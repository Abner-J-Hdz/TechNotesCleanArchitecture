
using Microsoft.EntityFrameworkCore;
using TechNotes.Domain.Entities;

namespace TechNotes.Infrastructure;
public class ApplicationDbContext: DbContext
{
	public ApplicationDbContext(DbContextOptions options): base(options)
	{
		
	}

	public DbSet<Notes> Notes { get; set; }

}
