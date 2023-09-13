using GPI.Horizon.Common.Interfaces.Query;
using MediatR;
using Suffolk.Core.Queries;

namespace Suffolk.Core.Handlers
{
    public class GetPersonByIdHandler : IQueryHandler<GetPersonByIdQuery, Person>
    {
        private IMediator _mediator;

        public GetPersonByIdHandler(IMediator mediator) 
        {
            _mediator = mediator;
        }
        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await  _mediator.Send(new GetPersonListQuery());
            var person = result.FirstOrDefault(x=>x.Id.ToString() == request.id);
            return person;
        }
    }
}
