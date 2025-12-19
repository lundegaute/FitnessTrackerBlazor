using FitnessTracker.Models;


namespace FitnessTracker.DTO;

public class ExerciseDTO
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required Musclegroup Agonist { get; set; } // Main muscle
    public required ExerciseType ExerciseType { get; set; } // Compound or isolation
    public required List<Musclegroup> Synergists { get; set; } = new List<Musclegroup>();
}