using Microsoft.EntityFrameworkCore;
using PersonRepositoty.Interface;
using System;



namespace PeopleService.SQL
{
    public class PersonContext : DbContext
    {

        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        { }

        public DbSet<Person> People { get; set; }
    }
}
