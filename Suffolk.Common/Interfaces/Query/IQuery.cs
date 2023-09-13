using MediatR;

namespace GPI.Horizon.Common.Interfaces.Query
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}
