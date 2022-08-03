using Names.Model;
using MediatR;

namespace Names.Commands
{
    public class PersonDeleteCommand : IRequest<Person>
    {
        public int ID { get; set; }
    }
}
