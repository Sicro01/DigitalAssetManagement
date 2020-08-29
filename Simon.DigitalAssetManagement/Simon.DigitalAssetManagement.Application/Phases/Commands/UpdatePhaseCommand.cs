using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Simon.DigitalAssetManagement.Application.Common.Interfaces;
using Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases;
using Simon.DigitalAssetManagement.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Simon.DigitalAssetManagement.Application.Phases.Commands
{
    public class UpdatePhaseCommand : IRequest<int>
    {
        public PhaseDto UpdatedPhase { get; set; }

        public UpdatePhaseCommand()
        {
        }
        public class UpdatePhaseCommandHandler : IRequestHandler<UpdatePhaseCommand, int>
        {
            private readonly IApplicationDbContext _context;
            //private readonly IMapper _mapper;

            public UpdatePhaseCommandHandler(IApplicationDbContext context)
            {
                _context = context;
                //_mapper = mapper;
            }

            public async Task<int> Handle(UpdatePhaseCommand request, CancellationToken cancellationToken)
            {
                var originalEntity = await _context.Phases.FindAsync(request.UpdatedPhase.Id);
                originalEntity.Name = request.UpdatedPhase.Name;
                originalEntity.StartDate = request.UpdatedPhase.StartDate;
                originalEntity.EndDate = request.UpdatedPhase.EndDate;
                _context.Phases.Update(originalEntity);
                await _context.SaveChangesAsync(cancellationToken);
                
                return originalEntity.Id;
            }
        }
    }
}
