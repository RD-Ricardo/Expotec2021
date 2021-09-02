using Expotec2021.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class ListTaskConfiguration : IEntityTypeConfiguration<ListTask>
    {
        public void Configure(EntityTypeBuilder<ListTask> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(n => n.Name).HasMaxLength(100).IsRequired();
            builder.Property(d => d.Description).HasMaxLength(200);
            builder.Property(c => c.UserId).IsRequired();
        }
    }
}