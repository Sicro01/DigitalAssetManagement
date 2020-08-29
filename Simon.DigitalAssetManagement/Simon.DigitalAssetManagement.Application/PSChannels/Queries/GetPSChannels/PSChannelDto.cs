using System.Collections.Generic;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Channels.Queries.GetChannels;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies;
using Simon.DigitalAssetManagement.Application.PSChannelCountries.Queries.GetPSChannelCountries;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.PSChannels.Queries.GetPSChannels
{
    public class PSChannelDto : IMapFrom<PSChannel>
    {
        public PSChannelDto()
        {
                PSChannelCountryList = new List<PSChannelCountryDto>();
        }
        public int Id { get; set; }
        public int PhaseStrategyId { get; set; }
        public PhaseStrategyDto PhaseStrategy { get; set; }
        public int ChannelId { get; set; }
        public ChannelDto Channel { get; set; }
        public IList<PSChannelCountryDto> PSChannelCountryList { get; private set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PSChannel, PSChannelDto>();
        }
    }
}
