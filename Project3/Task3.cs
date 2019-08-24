using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project3
{
    public class Task3
    {
        public const int numberOfRecordsPerPage = 5;


        public int NumberOfPages
        {
            get {
                int numberOfPages = 0;
                var numberOfRecords = StringItems.Count;
                
                numberOfPages = numberOfRecords / numberOfRecordsPerPage;
                if ((numberOfRecords == 0) || (numberOfPages * numberOfRecordsPerPage < numberOfRecords))
                {
                    numberOfPages += 1;
                }
                return numberOfPages;
            }
        }
        public List<string> StringItems { get; set; }
        public Task3()
        {
            var items = new List<string>();
            for (int i = 0; i < 104; i++)
            {
                items.Add(RandomString(4, false));
            }
            Console.WriteLine("initial elements count:{0}", items.Count);
            List<string> distinct = items.Where(s => !s.StartsWith('Z')).Distinct().OrderByDescending(p => p).ToList();
            Console.WriteLine("distinct elements count:{0}", distinct.Count());
            StringItems = new List<string>(distinct);
        }

        // Generate a random string with a given size  
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public void DisplayPage(int pageNumber)
        {
            // var elementsToShow = StringItems.GetRange((pageNumber - 1) * numberOfRecordsPerPage, numberOfRecordsPerPage);
            List<string> elementsToShow = new List<string>();
            for (int i = (pageNumber - 1) * numberOfRecordsPerPage; i < (pageNumber - 1) * numberOfRecordsPerPage + numberOfRecordsPerPage; i++)
            {
                if (StringItems.Count > i && pageNumber > 0)
                    elementsToShow.Add(StringItems[i]);
            }
            Console.WriteLine("{0} records on page {1}", elementsToShow.Count, pageNumber);
            elementsToShow?.ForEach(p => Console.WriteLine(p));
        }
    }
}
