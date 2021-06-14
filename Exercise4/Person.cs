using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Person
    {
        protected int age;
        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
