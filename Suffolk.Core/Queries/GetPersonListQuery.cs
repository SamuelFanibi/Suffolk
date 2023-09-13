using GPI.Horizon.Common.Interfaces.Query;
using System.Collections.Generic;

namespace Suffolk.Core.Queries
{
    public record GetPersonListQuery(): IQuery<List<Person>>;

}
