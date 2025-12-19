
namespace FitnessTracker.Models;

public class User
{
    public int Id { get; set;}
    public required string Username { get; set;}
    public required string HashedPassword { get; set;}
    public DateTime RegistrationDate { get; set;}
}