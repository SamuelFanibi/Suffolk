using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI.Horizon.Common.Interfaces.Command
{
    public interface ICommandModule
    {
        Task ExecuteCommandAsync(ICommand command);
    }
}
