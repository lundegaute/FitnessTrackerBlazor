
namespace FitnessTracker.Models;


public class Set
{
    public int Id { get; set; }
    public int ExerciseId { get; set; }
    //public Exercise Exercise { get; set; }
    public double Weight { get; set; }
    public int Reps { get; set; }
    public int RPE { get; set; }
    public int SetNumber { get; set; }

}