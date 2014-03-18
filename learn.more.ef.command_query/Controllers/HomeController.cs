using System.Web.Mvc;
using Data.Helpers;
using Domain.Customers;
using Domain.Home;

namespace learn.more.ef.command_query.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var vm = new HomeCommand
            {
                Number = 0
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult SquareResult(HomeCommand command)
        {
            var vm = Mediator.Send(command);

            return View(vm);
        }

        public ActionResult Customers()
        {
            var vm = Mediator.Request(new GetAllQuery<Customer>());

            return View(vm);
        }
    }
}