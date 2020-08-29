using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies;
using Simon.DigitalAssetManagement.Domain.Entities;

namespace Simon.DigitalAssetManagement.Application.Strategies.Queries.GetStrategies
{
    public class StrategyDto : IMapFrom<Strategy>
    {
        //public StrategyDto()
        //{
        //        PhasesStrategyList = new List<PhaseStrategyDto>();
        //}
        public int Id { get; set; }
        
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public virtual IList<PhaseStrategyDto> PhasesStrategyList { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Strategy, StrategyDto>();
        }
    }
}
