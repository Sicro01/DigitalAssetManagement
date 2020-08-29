using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Simon.DigitalAssetManagement.Application.Common.Behaviours;
using Simon.DigitalAssetManagement.Application.Phases.Commands;

namespace Simon.DigitalAssetManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehaviour<,>));
            services.AddValidatorsFromAssemblyContaining<UpdatePhaseCommandValidator>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            
            return services;
        }
    }
}
