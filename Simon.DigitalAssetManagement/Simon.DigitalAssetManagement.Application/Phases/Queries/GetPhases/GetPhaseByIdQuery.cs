using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Simon.DigitalAssetManagement.Application.Common.Interfaces;
using Simon.DigitalAssetManagement.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases
{
    public class GetPhaseByIdQuery : IRequest<PhaseVm>
    {
        public int Id { get; set; }
        public GetPhaseByIdQuery()
        {
        }

        public class GetAPhaseByIdQueryHandler : IRequestHandler<GetPhaseByIdQuery, PhaseVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAPhaseByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<PhaseVm> Handle(GetPhaseByIdQuery request, CancellationToken cancellationToken)
            {
                var result = new PhaseVm
                {
                    PhaseDto = await _context.Phases.Where(p => p.Id == request.Id)
                        .ProjectTo<PhaseDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(cancellationToken)
                };
                return result;
            }
        }
    }
}
