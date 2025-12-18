

namespace FitnessTracker.Models;


// Workout must belong to a user

public class Workout
{
    public int Id { get; set; }

    // Workout belongs to a user
    public int UserId { get; set;}
    public required User User { get; set;}

    // Workout has many logged exercises
    public ICollection<LoggedExercise>? LoggedExercises { get; set; }

    // Workout Details
    public DateTime SessionDate { get; set;}
    public int DurationInMinutes { get; set;}
    public string? Notes { get; set;}

}