using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Infrastructure.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .Property(c => c.Code)
                .HasColumnName("Code")
                .HasMaxLength(3)
                .IsRequired();

            builder
                .Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
