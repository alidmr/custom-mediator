using System.Threading.Tasks;
using CustomMediator.Library.Interfaces;

namespace CustomMediator.Api.Query
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        public Task<UserViewModel> Handle(GetUserByIdQuery request)
        {
            // get data from db

            return Task.FromResult(new UserViewModel()
            {
                FirstName = "Ali",
                LastName = "Demir"
            });
        }
    }
}