using Names.Model;

namespace Names.Commands
{
    public interface IPersonCommand
    {
        void SavePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int ID);
    }
}
