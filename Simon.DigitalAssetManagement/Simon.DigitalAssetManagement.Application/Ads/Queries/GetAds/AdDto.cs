using System.Collections.Generic;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.PSChannelCountryAds.Queries.GetPSChannelCountryAds;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.Ads.Queries.GetAds
{
    public class AdDto : IMapFrom<Ad>
    {
        public AdDto()
        {
                PSChannelCountryAds = new List<PSChannelCountryAdDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public string Dimensions { get; set; }
        public string CopyRequest { get; set; }
        public string AspectRatio { get; set; }
        public string FileTypes { get; set; }
        public string FileSize { get; set; }
        public string VideoDuration { get; set; }
        public IList<PSChannelCountryAdDto> PSChannelCountryAds { get; private set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Ad, AdDto>();
        }
    }
}
