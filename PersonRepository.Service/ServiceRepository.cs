using Newtonsoft.Json;
using PersonRepositoty.Interface;
using System;
using System.Collections.Generic;
using System.Net;

namespace PersonRepository.Service
{
        public class ServiceRepository : IPersonReader
        {
            private readonly WebClient _webClient = new WebClient();
            private readonly string _baseUri = "http://localhost:9874/api/people";

            public IEnumerable<Person> GetPeople()
            {
                string result = _webClient.DownloadString(_baseUri);
                IEnumerable<Person> people = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);
                return people;
            }

            public Person GetPerson(int id)
            {
                throw new NotImplementedException();
            }
        }
}
