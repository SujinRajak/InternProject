using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace WorkerHub.Controllers
{
    public class PaymentController : Controller
    {

        [HttpGet]
        public IActionResult Rooster(DataSourceLoadOptions loadOptions)
        {
            return View();
        }
    }
}
