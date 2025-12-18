

namespace FitnessTracker.Models;


public class ProgramAssignment
{
    public int Id { get; set; }
    
    // User relation
    public int UserId { get; set; }
    public required User User { get; set; }

    // Program relation
    public int ProgramId { get; set; }
    public required Program Program { get; set; }

    // Details
    public DateTime StartedProgramAt { get; set;}
    public bool IsActive { get; set; }
}