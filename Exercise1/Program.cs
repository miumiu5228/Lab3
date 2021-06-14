using System;

namespace Exercise1
{
    class Program
    {
        public static void Calculate(Shape S)
        {

            Console.WriteLine("Area is {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }

        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle();
            Calculate(rectangle);
            Shape circle = new Circle();
            Calculate(circle);
           
        }
    }
}
