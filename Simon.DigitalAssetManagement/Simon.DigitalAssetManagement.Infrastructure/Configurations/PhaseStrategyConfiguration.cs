using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Infrastructure.Configurations
{
    public class PhaseStrategyConfiguration : IEntityTypeConfiguration<PhaseStrategy>
    {
        public void Configure(EntityTypeBuilder<PhaseStrategy> builder)
        {
            builder
                .HasOne(ps => ps.Phase)
                .WithMany(p => p.PhaseStrategies)
                .HasForeignKey(p => p.PhaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(ps => ps.Strategy)
                .WithMany(s => s.PhasesStrategies)
                .HasForeignKey(p => p.StrategyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
