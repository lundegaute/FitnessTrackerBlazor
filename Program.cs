using FitnessTracker.Components;
using FitnessTracker.Interface;
using FitnessTracker.Repository;
using FitnessTracker.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using FitnessTracker.Data;
using FitnessTracker.Data.Seed;
using FitnessTracker.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// MySql Database connection
var connectionString = builder.Configuration.GetConnectionString("FitnessTrackerDbConnection")
    ?? throw new InvalidOperationException("Connectionstring not found");
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// Add Services for DI:
builder.Services.AddMyScopedServices();


var app = builder.Build();

// Initialize database with basic data for testing
using(var scope = app.Services.CreateScope())
{
    var _context = scope.ServiceProvider.GetRequiredService<DataContext>();
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    _context.Database.Migrate();
    await ExerciseSeed.InitialExerciseData(_context, logger);
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
