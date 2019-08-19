using System;


namespace Task6
{
    public class Square : Figure
    {
        public override string Draw()
        {
            var name = "I'm the Square";
            Console.WriteLine(name);
            return name;
        }
    }
}
