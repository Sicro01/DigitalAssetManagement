using System.Collections.Generic;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases;
using Simon.DigitalAssetManagement.Application.PSChannels.Queries.GetPSChannels;
using Simon.DigitalAssetManagement.Application.Strategies.Queries.GetStrategies;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies
{
    public class PhaseStrategyDto : IMapFrom<PhaseStrategy>
    {
        //public PhaseStrategyDto()
        //{
        //        PSChannels = new List<PSChannelDto>();
        //}
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public virtual PhaseDto Phase { get; set; }
        public int StrategyId { get; set; }
        public virtual StrategyDto Strategy { get; set; }
        public IList<PSChannelDto> PSChannels { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PhaseStrategy, PhaseStrategyDto>();
        }
    }
}
