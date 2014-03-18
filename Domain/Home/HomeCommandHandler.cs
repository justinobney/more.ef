using Envoc.Mediator;

namespace Domain.Home
{
    public class HomeCommandHandler: ICommandHandler<HomeCommand, HomeResult>
    {
        public HomeResult Handle(HomeCommand command)
        {
            return new HomeResult
            {
                Result = command.Number * command.Number
            };
        }
    }
}