using Names.DTO;
using Names.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Names.Queries
{
    public class PersonQuery
    {
        private readonly IPersonQueryRepository _repository;
        public PersonQuery(IPersonQueryRepository repository)
        {
            _repository = repository;
        }
        public List<PersonDTO> GetAll()
        {
            var people = _repository.GetAll();

            var query = from p in people
                        select new PersonDTO
                        {
                            FirstName = p.FirstName,
                            LastName = p.LastName,
                            BirthDate = p.BirthDate
                        };

            return query.ToList();
        }

        //public PersonDTO GetByID(int ID)
        //{
        //    var person = _repository.GetByID(ID);

        //    return new PersonDTO()
        //    {
        //        FirstName = person.FirstName,
        //        LastName = person.LastName,
        //        BirthDate = person.BirthDate
        //    };
        //}
    }
}
