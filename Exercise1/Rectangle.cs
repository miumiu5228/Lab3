using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle : Shape
    {
        public override float Area() 
        {
            Console.WriteLine("Please enter the length of the rectangle:");
            this.length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the length of the rectangle:");
            this.breadth = Convert.ToInt32(Console.ReadLine());

            return (float)(this.length* this.breadth);
        }
        public override float Circumference()
        {
            return (float)(this.length * 2 + this.breadth * 2);
        }

    }
}
