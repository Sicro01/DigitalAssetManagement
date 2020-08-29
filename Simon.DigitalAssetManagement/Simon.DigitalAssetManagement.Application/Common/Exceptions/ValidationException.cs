using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simon.DigitalAssetManagement.Application.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("One or more validation failure have occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public Dictionary<string, string[]> Errors { get; set; }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            var failureGroups = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage);

            foreach (var failureGroup in failureGroups)
            {
                var propertyName = failureGroup.Key;
                var propertyFailures = failureGroup.ToArray();

                Errors.Add(propertyName, propertyFailures);
            }
        }
    }
}