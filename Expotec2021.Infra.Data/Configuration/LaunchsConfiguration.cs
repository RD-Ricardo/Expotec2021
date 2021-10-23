using Expotec2021.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class LaunchsConfiguration : IEntityTypeConfiguration<Launchs>
    {
        public void Configure(EntityTypeBuilder<Launchs> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(n => n.Name);
            // builder.Property(d => d.Description).HasMaxLength(150);
            // builder.Property(p => p.price).HasPrecision(10,2);
            // builder.Property(o => o.Operation).IsRequired();
            // builder.HasOne(e => e.Category).WithMany(c => c.Launchs).HasForeignKey(c => c.CategoryId);
            builder.Property(r => r.ApplicationUserId).IsRequired();
            builder.Property(p => p.price).HasPrecision(6,2);
        }
    }
}