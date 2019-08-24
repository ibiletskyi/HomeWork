using System;
using System.Collections.Generic;

namespace Project3
{
    public class Task1
    {        
        public List<Person> Persons { get; set; }               
        public Task1()
        {
            Persons = new List<Person>();
            Persons.Add(new Person { Age = 21, Name = "Jon", PhoneNumbers = new[] { "09334532123", "09334323423", "09334532344" } });
            Persons.Add(new Person { Age = 18, Name = "Alice", PhoneNumbers = new[] { "0955550066", "0951234341", "09523423423" } });
            Persons.Add(new Person { Age = 42, Name = "Mark", PhoneNumbers = new[] { "0973453434", "09734534555", "09745345324" } });
            Persons.Add(new Person { Age = 30, Name = "Erik", PhoneNumbers = new[] { "09634532123", "09634323423", "09634532344" } });
            Persons.Add(new Person { Age = 37, Name = "Anrij", PhoneNumbers = new[] { "07334532123", "07334323423", "07334532344" } });
            Persons.Add(new Person { Age = 61, Name = "Petro", PhoneNumbers = new[] { "05034532123", "05034323423", "05034532344" } });
        }

        public void Draw()
        {
            Console.WriteLine("Display {0} stored persons", Persons?.Count);
            foreach (var person in Persons)
            {
                Console.WriteLine("Name:{0} - Age:{1}", person.Name, person.Age);
            }
        }

        public int GetCountOfPersons()
        {
            return Persons.Count;
        }

    }
}
