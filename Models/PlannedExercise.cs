

namespace FitnessTracker.Models;

public class PlannedExercise
{
    public int Id { get; set; }
    
    // PlannedExercise belongs to a program
    public int ProgramId { get; set; }
    public required Program Program { get; set; }
    
    // plannedExercise belongs to an exercise
    public int ExerciseId { get; set; }
    public required Exercise Exercise { get; set; }

    // Extra data
    public int OrderIndex { get; set; }
    public int TargetSets { get; set; } = 3;
    public int TargetReps { get; set; } = 10;
    public decimal RPE { get; set; } = 9;
    public string? Notes { get; set; }

}