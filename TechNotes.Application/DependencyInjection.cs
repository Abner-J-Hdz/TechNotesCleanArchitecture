using Microsoft.Extensions.DependencyInjection;
using TechNotes.Application.Interfaces;
using TechNotes.Application.Services;

namespace TechNotes.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();

        return services;
    }
}
