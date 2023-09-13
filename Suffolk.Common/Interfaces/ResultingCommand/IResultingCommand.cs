using MediatR;

namespace GPI.Horizon.Common.Interfaces.ResultingCommand
{
    public interface IResultingCommand<out TResult> : IRequest<TResult>
    {
    }
}