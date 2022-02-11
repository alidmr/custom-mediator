using CustomMediator.Library.Interfaces;

namespace CustomMediator.Api.Command
{
    public class UpdateNameCommand : IRequest<int>
    {
        public string FirstName { get; init; }

        public UpdateNameCommand(string firstName)
        {
            FirstName = firstName;
        }
    }
}
