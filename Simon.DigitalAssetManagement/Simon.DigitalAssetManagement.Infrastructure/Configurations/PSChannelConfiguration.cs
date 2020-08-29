using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Infrastructure.Configurations
{
    public class PSChannelConfiguration : IEntityTypeConfiguration<PSChannel>
    {
        public void Configure(EntityTypeBuilder<PSChannel> builder)
        {
            builder
                .HasOne(p => p.PhaseStrategy)
                .WithMany(p => p.PSChannels)
                .HasForeignKey(p => p.PhaseStrategyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.Channel)
                .WithMany(p => p.PSChannels)
                .HasForeignKey(p => p.ChannelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
