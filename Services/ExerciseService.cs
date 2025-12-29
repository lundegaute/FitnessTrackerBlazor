using FitnessTracker.Models;
using FitnessTracker.Interface.IRepository;
using FitnessTracker.Interface.IServices;
using FitnessTracker.DTO;

namespace FitnessTracker.Services;

public class ExerciseService : IExerciseService
{
    private readonly IRepository<Exercise> _exerciseRepository;

    public ExerciseService(IRepository<Exercise> exerciseRepository)
    {
        _exerciseRepository = exerciseRepository;
    }


    public async Task<List<ExerciseDTO>> GetAllExercisesAsync()
    {
        var exercises = await _exerciseRepository.GetValuesAsync();
        var exercisesDTO = exercises.Select(e => new ExerciseDTO
        {
            Id = e.Id,
            Name = e.Name,
            Agonist = e.Agonist,
            ExerciseType = e.ExerciseType,
            Synergists = e.Synergists,
        })
        .ToList();

        return exercisesDTO;
    }

    public Task<ExerciseDTO> GetExerciseByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddExerciseAsync(ExerciseDTO exercise)
    {
        throw new NotImplementedException();
    }
    
    public Task UpdateExerciseAsync(ExerciseDTO exercise)
    {
        throw new NotImplementedException();
    }

    public Task DeleteExerciseAsync(int id)
    {
        throw new NotImplementedException();
    }

}