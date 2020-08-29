using FluentValidation;

namespace Simon.DigitalAssetManagement.Application.Phases.Commands
{
    public class UpdatePhaseCommandValidator : AbstractValidator<UpdatePhaseCommand>
    {
        public UpdatePhaseCommandValidator()
        {
            RuleFor(p => p.UpdatedPhase.EndDate)
                .GreaterThan(p => p.UpdatedPhase.StartDate).WithMessage("Phase End Date must be greater than Phase Start Date.");
            RuleFor(p => p.UpdatedPhase.Name)
                .Length(1, 30).NotEmpty().WithMessage("Phase Name must have between 1 and 30 characters.");
        }
    }
}
