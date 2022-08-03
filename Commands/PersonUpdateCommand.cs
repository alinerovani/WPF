using Names.Model;
using MediatR;

namespace Names.Commands
{
    public class PersonUpdateCommand : IRequest<Person>
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
