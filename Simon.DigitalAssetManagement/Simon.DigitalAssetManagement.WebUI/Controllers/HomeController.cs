using System.Security.Cryptography.X509Certificates;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Simon.DigitalAssetManagement.Application.Common.Interceptors;
using Simon.DigitalAssetManagement.Application.Phases.Queries.GetPhases;

namespace Simon.DigitalAssetManagement.WebUI.Controllers
{

    public class HomeController : Controller
    {
        public string MyModel{ get; set; }

        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        //    ViewData["ExceptionPath"] = exceptionDetails.Path;
        //    ViewData["ExceptionMessage"] = exceptionDetails.Error.Message;
        //    ViewData["StackTrace"]= exceptionDetails.Error.StackTrace;

        //    return View("BespokeError");

        //    //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public ActionResult Error([CustomizeValidator(Interceptor = typeof(UserErrorCodeInterceptor))] PhaseDto model)
        {
            return View("BespokeError");
        }
    }
}
