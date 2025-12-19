using FitnessTracker.Models;
using FitnessTracker.Interface;
using FitnessTracker.DTO;

namespace FitnessTracker.Services;

public class ExerciseService
{
    private readonly IRepository<Exercise> _exerciseRepository;

    public ExerciseService(IRepository<Exercise> exerciseRepository)
    {
        _exerciseRepository = exerciseRepository;
    }

    public async Task<List<ExerciseDTO>> GetExercises()
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

}