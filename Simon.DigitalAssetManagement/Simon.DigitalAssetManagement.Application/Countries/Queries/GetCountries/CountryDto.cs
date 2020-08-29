using System.Collections.Generic;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.PSChannelCountries.Queries.GetPSChannelCountries;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.Countries.Queries.GetCountries
{
    public class CountryDto : IMapFrom<CountryDto>
    {
        public CountryDto()
        {
                PSChannelCountryList = new List<PSChannelCountryDto>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<PSChannelCountryDto> PSChannelCountryList { get; private set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Country, CountryDto>();
        }
    }
}
