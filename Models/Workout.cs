

namespace FitnessTracker.Models;


// Workout must belong to a user
// 
public class Workout
{
    public int Id { get; set; }
    public int UserId { get; set;}
    public User User { get; set;} = null!;
    public DateTime Date { get; set;}
    public int DurationInMinutes { get; set;}
    public string? Notes { get; set;}
    public ICollection<Set> Sets { get; set;} = new List<Set>();

}