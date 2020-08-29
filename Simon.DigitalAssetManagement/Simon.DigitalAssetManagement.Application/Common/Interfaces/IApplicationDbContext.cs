using Microsoft.EntityFrameworkCore;
using Simon.DigitalAssetManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Simon.DigitalAssetManagement.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<PhaseStrategy> PhaseStrategies { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<PSChannel> PSChannels { get; set; }
        public DbSet<PSChannelCountry> PSChannelCountries { get; set; }
        public DbSet<PSChannelCountryAd> PSChannelCountryAds { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
