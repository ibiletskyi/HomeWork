﻿using System;

namespace Task7
{
    public class Rectangle : Figure
    {
        public Rectangle(float x, float y) : base(x, y)
        {

        }

        public override string Draw()
        {
            var name = "I'm the Rectangle";
            Console.WriteLine(name);
            return name;
        }
    }
}
