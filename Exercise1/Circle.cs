using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Circle : Shape
    {
        double pi = Math.PI;
        public override float Area()
        {
            Console.WriteLine("Please enter the radius  of the rectangle:");
            this.radius = Convert.ToInt32(Console.ReadLine());


            return (float)Math.Round((Math.Pow(this.radius, 2.0) * pi), 1, MidpointRounding.AwayFromZero);

        }

        public override float Circumference()
        {
            return (float)Math.Round((2 * this.radius * pi), 1, MidpointRounding.AwayFromZero);
           
            ;
        }
    }
}
