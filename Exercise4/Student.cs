using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Student : Person
    {

        public void GoToClassed()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is { this.age } years old" );
        }
    }
}
