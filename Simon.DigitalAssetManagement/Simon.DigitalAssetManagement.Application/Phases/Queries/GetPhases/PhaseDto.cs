using AutoMapper;
using FluentValidation;
using Simon.DigitalAssetManagement.Application.Common.Mappings;
using Simon.DigitalAssetManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies;

namespace Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases
{
    public class PhaseDto : IMapFrom<Phase>
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public virtual IList<PhaseStrategyDto> PhaseStrategyList { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Phase, PhaseDto>();
        }
    }
}
