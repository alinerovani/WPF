using Names.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Names.Commands
{
    public class PersonDeleteCommandHandler : IRequestHandler<PersonDeleteCommand, Person>
    {
        public async Task<Person> Handle(PersonDeleteCommand request, CancellationToken cancellationToken)
        {
            var person = new Person();
            //request.Id
            return person;
        }
    }
}
