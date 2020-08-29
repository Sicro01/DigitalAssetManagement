using System.Collections.Generic;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.PSChannels.Queries.GetPSChannels;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.Channels.Queries.GetChannels
{
    public class ChannelDto : IMapFrom<Channel>
    {
        public ChannelDto()
        {
                PSChannelList = new List<PSChannelDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PSChannelDto> PSChannelList { get; private set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Channel, ChannelDto>();
        }
    }
}
