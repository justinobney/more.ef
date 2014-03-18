using System.Web.Mvc;
using Envoc.Mediator;

namespace learn.more.ef.command_query.Controllers
{
    public class BaseController: Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Mediator = DependencyResolver.Current.GetService<IMediator>();

        }

        public IMediator Mediator { get; set; }
    }
}