using GPI.Horizon.Common.Interfaces.Query;
using Suffolk.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suffolk.Core.Handlers
{
    public class GetPersonListHandler : IQueryHandler<GetPersonListQuery, List<Person>>
    {
        public IPersonDataAccess _personDataAccess { get; set; }
        public GetPersonListHandler(IPersonDataAccess personDataAccess ) 
        {
            _personDataAccess = personDataAccess;
        }
        public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_personDataAccess.GetPeople());
        }
    }
}
