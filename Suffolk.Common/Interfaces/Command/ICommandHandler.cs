using MediatR;

namespace GPI.Horizon.Common.Interfaces.Command
{
    public interface ICommandHandler<in TCommand> :
        IRequestHandler<TCommand>
        where TCommand : ICommand
    {
    }
}
