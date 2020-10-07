using System;

namespace PersonRepositoty.Interface
{
    public interface IPersonRepository : IPersonReader
    {
        void AddPerson(Person newPerson);

        void UpdatePerson(int id, Person updatedPerson);

        void DeletePerson(int id);
    }
}
