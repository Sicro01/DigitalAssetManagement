using Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases;
using System.Collections.Generic;
using Simon.DigitalAssetManagement.Application.Strategies.Queries.GetStrategies;

namespace Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies
{
    public class PhasesStrategiesVm
    {
        public IEnumerable<PhaseDto> PhaseList { get; set; }
        public IEnumerable<StrategyDto> StrategyList { get; set; }
        public IEnumerable<PhaseStrategyDto> PhaseStrategyList { get; set; }
    }
}
