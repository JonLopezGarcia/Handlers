using System.Threading.Tasks;

namespace Handlers
{
    public interface IHandler<in TRequest, TResult>
    {
        Task<TResult> Handle(TRequest request);
    }
}
