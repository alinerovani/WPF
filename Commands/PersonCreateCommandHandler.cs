using MediatR;
using Names.Model;
using System.Threading;
using System.Threading.Tasks;

namespace Names.Commands
{
    public class PersonCreateCommandHandler : IRequestHandler<PersonCreateCommand, Person>
    {
        public async Task<Person> Handle(PersonCreateCommand request, CancellationToken cancellationToken)
        {
            var person = new Person();
            person.FirstName = request.FirstName;
            person.LastName = request.LastName;
            person.Age = request.Age;

            //here it will save on write database 
            //await _context.SaveChangesAsync();
            return person;
        }
    }
}
