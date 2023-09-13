using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI.Horizon.Common.Interfaces.ResultingCommand
{
    public interface IResultingCommandHandler<in TCommand, TResult> :
        IRequestHandler<TCommand, TResult>
        where TCommand : IResultingCommand<TResult>
    {
    }
}
