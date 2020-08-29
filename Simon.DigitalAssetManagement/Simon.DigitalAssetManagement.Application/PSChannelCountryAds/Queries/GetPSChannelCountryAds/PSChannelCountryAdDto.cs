using AutoMapper;
using Simon.DigitalAssetManagement.Application.Ads.Queries.GetAds;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.PSChannelCountries.Queries.GetPSChannelCountries;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.PSChannelCountryAds.Queries.GetPSChannelCountryAds
{
    public class PSChannelCountryAdDto : IMapFrom<PSChannelCountryAd>
    {
        public int Id { get; set; }
        public int PSChannelCountryId { get; set; }
        public PSChannelCountryDto PSChannelCountry { get; set; }
        public int AdId { get; set; }
        public AdDto Ad { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PSChannelCountryAd, PSChannelCountryAdDto>();
        }
    }
}
