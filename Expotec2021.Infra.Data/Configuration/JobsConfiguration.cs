using Expotec2021.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class JobsConfiguration : IEntityTypeConfiguration<Jobs>
    {
        public void Configure(EntityTypeBuilder<Jobs> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(n => n.Name).HasMaxLength(50).IsRequired();
            builder.Property(d => d.Description).HasMaxLength(200).IsRequired();
            builder.Property(l => l.Location).HasMaxLength(100).IsRequired();
            builder.Property(l => l.Contact).HasMaxLength(20).IsRequired();
            builder.Property(e => e.ApplicationUserId).IsRequired();
        }
    }
}