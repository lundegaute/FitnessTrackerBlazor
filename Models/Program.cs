
namespace FitnessTracker.Models;


public class Program
{
    public int Id { get; set; }

    // A program needs to have exercises
    public required ICollection<PlannedExercise> PlannedExercises { get; set; }
   
    // Details
    public string Description { get; set; } = "";

}