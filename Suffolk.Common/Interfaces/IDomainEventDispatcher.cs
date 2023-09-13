using Suffolk.Common;
using Suffolk.Common.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Suffolk.Common.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
    }
}
