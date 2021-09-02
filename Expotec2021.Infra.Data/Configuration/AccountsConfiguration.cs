using Expotec2021.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expotec2021.Infra.Data.Configuration
{
    public class AccountsConfiguration : IEntityTypeConfiguration<Accounts>
    {
        public void Configure(EntityTypeBuilder<Accounts> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(u => u.UserId).IsRequired();
        }
    }
}