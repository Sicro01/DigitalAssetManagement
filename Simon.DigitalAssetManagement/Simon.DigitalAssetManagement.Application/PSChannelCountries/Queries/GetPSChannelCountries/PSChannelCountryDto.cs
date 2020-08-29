using System.Collections.Generic;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.Countries.Queries.GetCountries;
using Simon.DigitalAssetManagement.Application.PSChannelCountryAds.Queries.GetPSChannelCountryAds;
using Simon.DigitalAssetManagement.Application.PSChannels.Queries.GetPSChannels;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.PSChannelCountries.Queries.GetPSChannelCountries
{
    public class PSChannelCountryDto : IMapFrom<Strategy>
    {
        public PSChannelCountryDto()
        {
                PSChannelCountryAdList = new List<PSChannelCountryAdDto>();
        }
        public int Id { get; set; }
        //public int Id { get; set; }
        //public virtual Phase Phase { get; set; }
        //public int Id { get; set; }
        //public virtual Strategy Strategy { get; set; }
        //public int Id { get; set; }
        //public virtual Channel Channel { get; set; }
        public int CountryId { get; set; }
        public virtual CountryDto Country { get; set; }
        public int PSChannelId { get; set; }
        public virtual PSChannelDto PSChannel { get; set; }
        public IList<PSChannelCountryAdDto> PSChannelCountryAdList { get; private set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Strategy, PSChannelCountryDto>();
        }
    }
}
