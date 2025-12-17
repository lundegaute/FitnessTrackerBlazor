
namespace FitnessTracker.Models;


public class Set
{
    public int Id { get; set; }
    public required int ExerciseId { get; set; }
    public required Exercise Exercise { get; set; }
    public required double Weight { get; set; }
    public required int Reps { get; set; }
    public required int RPE { get; set; }
    public required int SetNumber { get; set; }

}