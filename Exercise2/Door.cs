using System;

namespace Exercise2
{
    class Door
    {
        protected string color;

        public Door()
        {
            color = "black";
        }
        public Door(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("The color of the door is {0}.", color);
        }

    }
}
