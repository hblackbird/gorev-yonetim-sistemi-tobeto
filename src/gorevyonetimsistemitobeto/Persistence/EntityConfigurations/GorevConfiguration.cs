using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class GorevConfiguration : IEntityTypeConfiguration<Gorev>
{
    public void Configure(EntityTypeBuilder<Gorev> builder)
    {
        builder.ToTable("Gorevs").HasKey(g => g.Id);

        builder.Property(g => g.Id).HasColumnName("Id").IsRequired();
        builder.Property(g => g.Title).HasColumnName("Title");
        builder.Property(g => g.Status).HasColumnName("Status");
        builder.Property(g => g.Description).HasColumnName("Description");
        builder.Property(g => g.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(g => g.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(g => g.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(g => !g.DeletedDate.HasValue);
    }
}