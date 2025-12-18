
namespace FitnessTracker.Models;


public class Set
{
    public int Id { get; set; }

    // A set needs to have a LoggedExercise. 
    public required int LoggedExerciseId { get; set; }
    public required LoggedExercise LoggedExercise { get; set; }

    // Set Details
    public required decimal Weight { get; set; }
    public required int Reps { get; set; }
    public required int RPE { get; set; }
    public required int SetNumber { get; set; }

}