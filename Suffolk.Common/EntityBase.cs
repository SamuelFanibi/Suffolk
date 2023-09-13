using Microsoft.EntityFrameworkCore.Metadata;
using Suffolk.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suffolk.Common
{
    public abstract class EntityBase: BaseDeletable<IKey>
    {
        //private List<DomainEventBase> _domainEvents = new();
        //[NotMapped]
        //public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

        //protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
        //internal void ClearDomainEvents() => _domainEvents.Clear();
    }
}
