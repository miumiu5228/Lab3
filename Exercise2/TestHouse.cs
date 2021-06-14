using System;

namespace Exercise2
{
    class TestHouse
    {
        static void Main(string[] args)
        {
            SmallApartment mySmallApartament = new SmallApartment();
            Person myPerson = new Person();

            myPerson.Name = "Kishore";
            myPerson.House = mySmallApartament;
            myPerson.ShowData();

            Person Person = new Person();
            Person.Name = "Hedy";
           
            Person.ShowData();


        }
    }
}
