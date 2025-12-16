using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

// Namespace is not needed, as IEntityTypeConfiguration is found through the .ApplyConfigurationsFromAssembly method in DataContext

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> entity)
    {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Name).IsRequired();
        entity.HasIndex(e => e.Name);
        entity.Property(e => e.ExerciseType)
            .HasConversion<string>()
            .HasMaxLength(50);
        entity.Property(e => e.Agonist)
            .HasConversion<string>()
            .HasMaxLength(50);
        entity.Property(e => e.Synergists)
            .HasConversion(
                synergist => JsonSerializer.Serialize(synergist, (JsonSerializerOptions?)null),
                synergist => JsonSerializer.Deserialize<List<Musclegroup>>(synergist, (JsonSerializerOptions?) null)
                    ?? new List<Musclegroup>()
            );
    }
}