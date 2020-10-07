using PersonRepositoty.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Service.Model
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
