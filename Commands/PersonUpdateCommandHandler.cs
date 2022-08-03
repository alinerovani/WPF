using Names.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Names.Commands
{
    public class PersonUpdateCommandHandler : IRequestHandler<PersonUpdateCommand, Person>
    {
        public async Task<Person> Handle(PersonUpdateCommand request, CancellationToken cancellationToken)
        {
            var person = new Person();
            //get from the list
            if (person == null)
                return default;
            else
            {
                person.FirstName = request.FirstName;
                person.LastName = request.LastName;
                person.Age = request.Age;
                //update the list
                //await _context.SaveChangesAsync();
                return person;
            }
        }
    }
}
