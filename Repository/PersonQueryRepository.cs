using Names.Model;
using System.Collections.Generic;
using System.Linq;

namespace Names.Repository
{
    public class PersonQueryRepository : IPersonQueryRepository
    {

        private List<Person> _repository;
        public PersonQueryRepository(List<Person> repository)
        {
            _repository = repository;
        }

        public List<Person> GetAll()
        {
            return _repository;
        }
    }
}
