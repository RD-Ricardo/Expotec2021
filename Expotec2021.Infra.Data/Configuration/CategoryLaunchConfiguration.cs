using Expotec2021.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class CategoryLaunchConfiguration : IEntityTypeConfiguration<CategoryLaunch>
    {
        public void Configure(EntityTypeBuilder<CategoryLaunch> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(n => n.Name).HasMaxLength(30).IsRequired();

            builder.HasData(
                new CategoryLaunch(1, "Contas"),
                new CategoryLaunch(2, "Comidas"),
                new CategoryLaunch(3, "Compras"),
                new CategoryLaunch(4, "Remédios"),
                new CategoryLaunch(5, "Investimentos"),
                new CategoryLaunch(6, "Diversos")
            );
        }
    }
}