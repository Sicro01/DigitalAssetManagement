using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Infrastructure.Configurations
{
    public class PSChannelCountryConfiguration : IEntityTypeConfiguration<PSChannelCountry>
    {
        public void Configure(EntityTypeBuilder<PSChannelCountry> builder)
        {
            builder.HasOne(p => p.Country)
                .WithMany(p => p.PSChannelCountries)
                .HasForeignKey(p => p.CountryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.PSChannel)
                .WithMany(p => p.PSChannelCountries)
                .HasForeignKey(p => p.PSChannelId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
