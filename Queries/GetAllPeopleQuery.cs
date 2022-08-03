using MediatR;
using Names.Model;
using System.Collections.Generic;

namespace Names.Queries
{
    public class GetAllPeopleQuery : IRequest<IEnumerable<Person>>
    {
    }
}
