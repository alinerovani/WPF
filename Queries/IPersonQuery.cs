using Names.DTO;
using System.Collections.Generic;

namespace Names.Queries
{
    public interface IPersonQuery 
    {
        List<PersonDTO> GetAll();
    }
}

