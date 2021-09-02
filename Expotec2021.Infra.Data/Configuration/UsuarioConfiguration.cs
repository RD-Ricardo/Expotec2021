using Expotec2021.Domain.Entities;
using Expotec2021.Infra.Identity.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).IsRequired();
            // builder.Property(e => e.Email).IsRequired().HasMaxLength(256);
            // builder.Property(i => i.UserName).IsRequired().HasMaxLength(256);  
        }
    }
}