using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TechNotes.Infrastructure;
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
	public ApplicationDbContext CreateDbContext(string[] args)
	{
		var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
		optionBuilder.UseSqlServer("Server=;Database=TechNotesDb;User ID=sa;Password=anrcode;TrustServerCertificate=true;MultipleActiveResultSets=true",
			b => b.MigrationsAssembly("TechNotes.Infrastructure"));

		return new ApplicationDbContext(optionBuilder.Options);
	}
}
