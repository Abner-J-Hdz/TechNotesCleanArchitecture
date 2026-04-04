
using Microsoft.EntityFrameworkCore;
using TechNotes.Domain.Entities;

namespace TechNotes.Infrastructure;
public class ApplicationDbContext: DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{
		
	}

	public DbSet<Notes> Notes { get; set; }

}
