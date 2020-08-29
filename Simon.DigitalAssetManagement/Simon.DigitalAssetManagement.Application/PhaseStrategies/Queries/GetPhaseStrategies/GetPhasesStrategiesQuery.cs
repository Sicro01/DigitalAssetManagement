using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Simon.DigitalAssetManagement.Application.Common.Interfaces;
using Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases;
using System.Threading;
using System.Threading.Tasks;
using Simon.DigitalAssetManagement.Application.Strategies.Queries.GetStrategies;

namespace Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies
{
    public class GetPhasesStrategiesQuery : IRequest<PhasesStrategiesVm>
    {
        public PhaseStrategyDto PhaseStrategyDto { get; set; }

        public GetPhasesStrategiesQuery()
        {
            
        }

        public class GetAllPhasesAndStrategiesQueryHandler : IRequestHandler<GetPhasesStrategiesQuery, PhasesStrategiesVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetAllPhasesAndStrategiesQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<PhasesStrategiesVm> Handle(GetPhasesStrategiesQuery request, CancellationToken cancellationToken)
            {
                return new PhasesStrategiesVm
                {
                    PhaseList = await _context.Phases.ProjectTo<PhaseDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken),
                    StrategyList = await _context.Strategies.ProjectTo<StrategyDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken),
                    PhaseStrategyList = await _context.PhaseStrategies.ProjectTo<PhaseStrategyDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken)
                };
            }
        }
    }
}
