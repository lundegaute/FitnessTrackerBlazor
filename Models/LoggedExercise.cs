

namespace FitnessTracker.Models;

public class LoggedExercise
{
    public int Id { get; set; }

    // LoggedExercise needs to point to the actual exercise
    public int ExerciseId { get; set; }
    public required Exercise Exercise { get; set; }

    // LoggedExercise belongs to a workout
    public int WorkoutId { get; set; }
    public required Workout Workout { get; set; }

    // LoggedExercise needs to have sets
    public ICollection<Set>? Sets { get; set;}


    // LoggedExercise specific data
    
}