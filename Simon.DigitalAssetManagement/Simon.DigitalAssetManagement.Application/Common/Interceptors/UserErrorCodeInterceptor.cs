using System.Linq;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Simon.DigitalAssetManagement.Application.Common.Interceptors
{
    public class UserErrorCodeInterceptor : IValidatorInterceptor
    {
        public UserErrorCodeInterceptor()
        {

        }
        //public ValidationResult AfterMvcValidation(ControllerContext controllerContext, IValidationContext commonContext, ValidationResult result)
        //{
        //    return (ValidationResult)commonContext;
        //}

        public IValidationContext BeforeMvcValidation(ControllerContext controllerContext, IValidationContext commonContext)
        {
            throw new System.NotImplementedException();
        }

        public FluentValidation.Results.ValidationResult AfterMvcValidation(ControllerContext controllerContext,
            IValidationContext commonContext, FluentValidation.Results.ValidationResult result)
        {
            var projection = result.Errors.Select(
                failure => new ValidationFailure(
                    failure.PropertyName,
                    JsonConvert.SerializeObject(new
                    {
                        message = failure.ErrorMessage,
                        code = failure.ErrorCode,
                        state = failure.CustomState
                    })));

            return new ValidationResult(projection);
        }

    }

}