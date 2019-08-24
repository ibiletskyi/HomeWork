namespace Project3
{
    public class Task2 : Task1
    {
        public Task2() : base()
        {
            var items = new Person[] {
             new Person{ Age = 30, Name = "Misha", PhoneNumbers = new[] { "07334532123", "07334323423", "07334532344" } },
             new Person{ Age = 57, Name = "Edik", PhoneNumbers = new[] { "05034532123", "05034323423", "05034532344" } }
            };
            Persons.AddRange(items);
        }
    }
}
