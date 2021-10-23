using Expotec2021.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class PostsConfiguration : IEntityTypeConfiguration<Posts>
    {
        public void Configure(EntityTypeBuilder<Posts> builder)
        {
            builder.HasKey(k => k.Id);
            //builder.Property(t => t.Title).HasMaxLength(30).IsRequired();
            builder.Property(d => d.Description).HasMaxLength(200);
            builder.Property(i => i.Image).HasMaxLength(250);
            builder.Property(c => c.ApplicationUserId).IsRequired();
        }
    }
}