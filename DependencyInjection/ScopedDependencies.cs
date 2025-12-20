using FitnessTracker.Interface;
using FitnessTracker.Models;
using FitnessTracker.Repository;


namespace FitnessTracker.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddMyScopedServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<Exercise>();

        return services;
    }
}