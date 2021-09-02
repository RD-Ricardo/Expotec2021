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
        }
    }
}