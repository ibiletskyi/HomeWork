using System.Collections.Generic;

namespace Project3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; } 
    }
}
