using Names.Model;
using Names.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Names.Commands
{
    public class PersonCommand : IPersonCommand
    {
        private readonly IPersonCommandRepository _repository;
        public PersonCommand(IPersonCommandRepository repository)
        {
            _repository = repository;
        }
        public void SavePerson(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
                throw new Exception("First name isn't defined!");

            if (string.IsNullOrWhiteSpace(person.LastName))
                throw new Exception("Last name isn't defined!");

            if (person.BirthDate == DateTime.MinValue)
                throw new Exception("Birth date isn't defined!");

            _repository.SavePerson(person);
        }

        public void UpdatePerson(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
                throw new Exception("First name isn't defined!");

            if (string.IsNullOrWhiteSpace(person.LastName))
                throw new Exception("Last name isn't defined!");

            if (person.BirthDate == DateTime.MinValue)
                throw new Exception("Birth date isn't defined!");

            _repository.UpdatePerson(person);
        }

        public void DeletePerson(int ID)
        {
            _repository.DeletePerson(ID);
        }
    }
}
