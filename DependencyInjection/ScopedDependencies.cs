using FitnessTracker.Services;
using FitnessTracker.Repository;
using FitnessTracker.Interface.IRepository;
using FitnessTracker.Interface.IServices;


namespace FitnessTracker.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddMyScopedServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<ExerciseService>();
        services.AddScoped<IExerciseService, ExerciseService>(); // Ensure ExerciseService is registered with its interface

        return services;
    }
}