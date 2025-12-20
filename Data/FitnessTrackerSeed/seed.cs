using FitnessTracker.Models;

namespace FitnessTracker.Data.Seed;

public static class ExerciseSeed
{
    public static async Task InitialExerciseData(DataContext _context, ILogger logger)
    {

        if (!_context.Exercises.Any())
        {
            _context.Exercises.AddRange(
                new Exercise
                {
                    Name = "Squat",
                    ExerciseType = ExerciseType.Compound,
                    Agonist = Musclegroup.Quads,
                    Synergists = [Musclegroup.Glutes],
                },
                new Exercise
                {
                    Name = "Bench Press",
                    ExerciseType = ExerciseType.Compound,
                    Agonist = Musclegroup.Chest,
                    Synergists = [Musclegroup.Shoulder, Musclegroup.Triceps],
                }
            );
            await _context.SaveChangesAsync();
            logger.LogInformation("Exercise table initialized");
        }
        else
        {
            logger.LogInformation("Exercise table already initialized");
        }
    }
}