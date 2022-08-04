using Names.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Names.Repository
{
    public class PersonCommandRepository : IPersonCommandRepository
    {
        private List<Person> _database;
        public PersonCommandRepository(List<Person> database)
        {
            _database = database;
        }

        public void SavePerson(Person person)
        {
            //Persist the record in the data store 
            _database.Add(person);
        }

        public void UpdatePerson(Person person)
        {
            int records = (from p in _database
                           where (p.FirstName == person.FirstName
                           && p.LastName == person.LastName
                           && p.BirthDate == person.BirthDate
                           && p.ID != person.ID)
                           select p).Count();
            if (records > 0)
                throw new Exception("Duplicated record!");

            //Update the record in the data store 
            _database[person.ID] = person;
        }

        public void DeletePerson(int ID)
        {
            //Delete the record in the data store 
            _database.RemoveAt(ID);
        }
    }
}
