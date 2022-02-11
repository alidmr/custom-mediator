using System.Linq;
using System.Threading.Tasks;
using CustomMediator.Library.Interfaces;

namespace CustomMediator.Library
{
    public class Mediator : IMediator
    {
        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
        {
            var reqType = request.GetType();
            var reqTypeInterface = reqType
                .GetInterfaces()
                .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequest<>));

            var responseType = reqTypeInterface.GetGenericArguments()[0];

            var genericType = typeof(IRequestHandler<,>).MakeGenericType(reqType, responseType);

            var handler = ServiceProvider.GetServiceProvider.GetService(genericType);

            return (Task<TResponse>) genericType.GetMethod("Handle")?.Invoke(handler, new object[] {request});
        }
    }
}