using GPI.Horizon.Common.Interfaces.Query;

namespace Suffolk.Core.Queries
{
    public record GetPersonByIdQuery(string id): IQuery<Person>;
    
}
