

namespace FitnessTracker.Models;

public class PlannedExercise
{
    public int Id { get; set; }
    
    // Relation to Program
    public int ProgramId { get; set; }
    public required Program Program { get; set; }
    
    // Relation to Exercise
    public int ExerciseId { get; set; }
    public required Exercise Exercise { get; set; }

    // Extra data
    public int OrderOfExercises { get; set; }
    public int TargetSets { get; set; } = 3;
    public int TargetReps { get; set; } = 10;
    public decimal RPE { get; set; } = 9;
    public string? Notes { get; set; }

}