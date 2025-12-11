

namespace FitnessTracker.Models;

public class Workout
{
    public int Id { get; set; }
    public int UserId { get; set;}
    public User User { get; set;}
    public DateTime Date { get; set;}
    public int DurationInMinutes { get; set;}
    public string Notes { get; set;}
    public ICollection<Set> Sets { get; set;}
    // Maybe i dont need Exercise here, since each set is refering to a specific exercise

}