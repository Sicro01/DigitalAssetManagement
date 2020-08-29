using FluentValidation;
using FluentValidation.Results;

namespace Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies
{
    public class GetPhasesStrategiesQueryValidator : AbstractValidator<GetPhasesStrategiesQuery>
    {
        //public GetPhasesStrategiesQueryValidator()
        //{
        //    RuleFor(p => p.PhaseStrategyDto)
        //        .NotEmpty().WithMessage("Phase Strategies must not be empty.");

        //    //RuleFor(p => p.PhaseStrategyDto.Phase.EndDate)
        //    //    .GreaterThan(p => p.PhaseStrategyDto.Phase.StartDate).WithMessage("Phase End Date must be greater than Phase Start Date.");
        //    //RuleFor(p => p.UpdatedPhase.Name)
        //    //    .Length(1, 30).NotEmpty().WithMessage("Phase Name must have between 1 and 30 characters.")
        //}

        //protected override bool PreValidate(ValidationContext<GetPhasesStrategiesQuery> context, ValidationResult result)
        //{
        //    if (context.InstanceToValidate == null)
        //    {
        //        foreach (var error in result.Errors)
        //        {
        //            result.Errors.Add(new ValidationFailure(error.PropertyName, error.ErrorMessage,
        //                error.AttemptedValue));
        //        }
        //    }
                
        //    //if (context.InstanceToValidate == null)
        //    //{
                
        //    //    result.Errors.Add(new ValidationFailure(result.Errors., "Please ensure a model was supplied."));
        //    //    return false;
        //    //}

        //    return true;
        //}
    }
}