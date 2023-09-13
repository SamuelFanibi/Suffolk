using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI.Horizon.Common.Interfaces.ResultingCommand
{
    public interface IResultingCommandModule
    {
        Task<TResult> ExecuteCommandAsync<TResult>(IResultingCommand<TResult> command);
    }
}
