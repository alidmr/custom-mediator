using System.Threading.Tasks;

namespace CustomMediator.Library.Interfaces
{
    public interface IMediator
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    }
}
