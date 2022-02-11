using System.Threading.Tasks;
using CustomMediator.Library.Interfaces;

namespace CustomMediator.Api.Command
{
    public class UpdateNameCommandHandler : IRequestHandler<UpdateNameCommand, int>
    {
        public Task<int> Handle(UpdateNameCommand request)
        {
            // update on db

            return Task.FromResult(1);
        }
    }
}