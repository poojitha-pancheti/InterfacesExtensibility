﻿using PersonRepositoty.Interface;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System;

namespace PeopleService.CSV
{
    class CsvRepository : IPersonReader
    {

        private readonly string _path;

        public CsvRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            _path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>();

            if (File.Exists(_path))
            {
                using (var reader = new StreamReader(_path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var elements = line.Split(',');
                        var person = new Person()
                        {
                            Id = Int32.Parse(elements[0]),
                            GivenName = elements[1],
                            FamilyName = elements[2],
                            StartDate = DateTime.Parse(elements[3]),
                            Rating = Int32.Parse(elements[4]),
                            FormatString = elements[5],
                        };
                        people.Add(person);
                    }
                }
            }
            return people;
        }

        public Person GetPerson(int id)
        {
            return GetPeople().FirstOrDefault(p => p.Id == id);
        }

    }
}
