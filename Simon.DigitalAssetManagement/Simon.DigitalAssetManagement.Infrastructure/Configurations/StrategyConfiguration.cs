using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Infrastructure.Configurations
{
    public class StrategyConfiguration : IEntityTypeConfiguration<Strategy>
    {
        public void Configure(EntityTypeBuilder<Strategy> builder)
        {
            builder
                .Property(s => s.Name)
                .HasColumnName("Name")
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(s => s.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(s => s.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
