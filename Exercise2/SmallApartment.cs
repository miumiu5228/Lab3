using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class SmallApartment : House
    {
        public SmallApartment() : base(100)
        {

        }
        public override void ShowData()
        {
            Console.WriteLine("The area of the apartment is " + area + " m2");
        }


    }
}
