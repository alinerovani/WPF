using MediatR;
using Names.Model;

namespace Names.Commands
{
    public class PersonCreateCommand : IRequest<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
