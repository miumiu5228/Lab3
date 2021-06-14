using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    abstract class Shape
    {
        protected float radius, length, breadth;
        public abstract float Area();
        public abstract float Circumference();

    }
}
