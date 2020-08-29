//using MediatR;
using Microsoft.AspNetCore.Mvc;
using Simon.DigitalAssetManagement.Application.Phases.Commands;
using Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using Simon.DigitalAssetManagement.Application.Common.Interceptors;
using Simon.DigitalAssetManagement.Application.PhaseStrategies.Queries.GetPhaseStrategies;

namespace Simon.DigitalAssetManagement.WebUI.Controllers
{
    public class PhaseStrategyController : Controller
    {
        private readonly IMediator _mediator;

        public PhaseStrategyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PhasesStrategiesVm>> Index()
        {
            return View(await _mediator.Send(new GetPhasesStrategiesQuery()));
        }

        [HttpGet]
        public async Task<IActionResult> EditPhase(int id)
        {
            var model = await _mediator.Send(new GetPhaseByIdQuery() { Id = id });
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditPhase(PhaseVm updatedPhase)
        {
            await _mediator.Send(new UpdatePhaseCommand() { UpdatedPhase = updatedPhase.PhaseDto });
            return RedirectToAction("Index");
        }
        //public ActionResult Error([CustomizeValidator(Interceptor = typeof(UserErrorCodeInterceptor))] PhaseDto model)
        //{
        //    return View("BespokeError");
        //}

        //public IActionResult Error()
        //{
        //    var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        //    ViewData["ExceptionPath"] = exceptionDetails.Path;
        //    ViewData["ExceptionMessage"] = exceptionDetails.Error.Message;
        //    ViewData["StackTrace"] = exceptionDetails.Error.StackTrace;

        //    return View("BespokeError");

        //    //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
    
}
