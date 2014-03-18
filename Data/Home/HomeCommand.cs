using Envoc.Mediator;

namespace Domain.Home
{
    public class HomeCommand : ICommand<HomeResult>
    {
        public int Number { get; set; }
    }
}
