using Names.Model;

namespace Names.Repository
{
    public interface IPersonCommandRepository
    {
        void SavePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int ID);
    }
}
