

namespace FitnessTracker.Models;

public enum Musclegroup
{
    Chest,
    Back,
    Shoulder,
    Biceps,
    Triceps,
    Abs,
    Glutes,
    Quads,
    Hamstring,
    Calves,
}
public enum ExerciseType
{
    Compound,
    Isolation,

}
public class Exercise
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required ExerciseType ExerciseType { get; set;}
    public required Musclegroup Agonist { get; set;}
    public List<Musclegroup>? Synergists { get; set; }
}
