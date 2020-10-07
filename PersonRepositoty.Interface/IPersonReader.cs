using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRepositoty.Interface
{
    public interface IPersonReader
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
    }
}
