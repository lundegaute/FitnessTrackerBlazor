
namespace FitnessTracker.Models;

public class User
{
    public int Id { get; set;}
    public string Username { get; set;}
    public string HashedPassword { get; set;}
    public DateTime RegistrationDate { get; set;}
}