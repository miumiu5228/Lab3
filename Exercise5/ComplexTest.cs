using System;

namespace Exercise5
{
    class ComplexTest
    {
        static void Main(string[] args)
        {

            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine(number);
           Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());

        }
    }
}
