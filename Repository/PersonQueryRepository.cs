using Names.Model;
using System.Collections.Generic;
using System.Linq;

namespace Names.Repository
{
    public class PersonQueryRepository : IPersonQueryRepository
    {

        private List<Person> _database;
        public PersonQueryRepository(List<Person> database)
        {
            _database = database;
        }

        //public Person GetByID(int ID)
        //{
        //    return _database.Where(x => x.ID == ID).Single();
        //}

        public List<Person> GetAll()
        {
            return _database;
        }
    }
}
