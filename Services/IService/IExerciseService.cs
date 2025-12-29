using FitnessTracker.DTO;

namespace FitnessTracker.Interface.IServices;

public interface IExerciseService
{
    // Define methods that ExerciseService should implement
    Task<List<ExerciseDTO>> GetAllExercisesAsync();
    Task<ExerciseDTO> GetExerciseByIdAsync(int id);
    Task AddExerciseAsync(ExerciseDTO exercise);
    Task UpdateExerciseAsync(ExerciseDTO exercise);
    Task DeleteExerciseAsync(int id);
}