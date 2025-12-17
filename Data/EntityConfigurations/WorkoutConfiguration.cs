using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models;



public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
{
    public void Configure(EntityTypeBuilder<Workout> entity)
    {
        entity.HasKey(w => w.Id);
        // Currently Building Workout entity
    }
}