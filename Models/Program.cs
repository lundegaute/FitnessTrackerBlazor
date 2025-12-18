
namespace FitnessTracker.Models;


public class Program
{
    public int Id { get; set; }

    // Exercice relation

    // PlannedExercise relation
    public int PlannedExerciseId { get; set; }
    public required PlannedExercise PlannedExercise { get; set; }
    // Details
}