using Names.Model;
using System.Collections.Generic;

namespace Names.Repository
{
    public interface IPersonQueryRepository
    {
        List<Person> GetAll();
        //Person GetByID(int ID);
    }
}
