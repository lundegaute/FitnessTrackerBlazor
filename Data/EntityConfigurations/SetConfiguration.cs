using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


public class SetConfiguration : IEntityTypeConfiguration<Set>
{
    public void Configure(EntityTypeBuilder<Set> entity)
    {
        entity.HasKey(s => s.Id);
        entity.Property(s => s.ExerciseId).IsRequired();
        entity.Property(s => s.Weight)
            .HasPrecision(5,1)
            .IsRequired();
            
        entity.Property(s => s.Reps)
            .IsRequired();

        entity.Property(s => s.RPE)
            .IsRequired()
            .HasDefaultValue(5);

        entity.Property(s => s.SetNumber).IsRequired();

        entity.HasOne(s => s.Exercise)
            .WithMany() // empty becuase Exercice does not have a navigation to Sets
            .HasForeignKey(s => s.ExerciseId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

    }
}