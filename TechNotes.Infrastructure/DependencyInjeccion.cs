using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechNotes.Domain.Interfaces;
using TechNotes.Infrastructure.Repositories;

namespace TechNotes.Infrastructure;
public static class DependencyInjeccion
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<ApplicationDbContext>(options =>
		{
			options.UseSqlServer(
				configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly("TechNotes.Infrastructure")
			);
		});
		services.AddScoped<INoteRepository, NoteRepositoy>();
		return services;
	}
}
