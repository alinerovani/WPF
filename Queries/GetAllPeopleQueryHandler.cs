using MediatR;
using Names.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Names.Queries
{
    public class GetAllPeopleQueryHandler : IRequestHandler<GetAllPeopleQuery, IEnumerable<Person>>
    {
        public async Task<IEnumerable<Person>> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            //return await _context.Produtos.ToListAsync();
            return null;
        }
    }
}

