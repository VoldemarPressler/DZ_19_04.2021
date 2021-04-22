using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class Basement : IPart
    {
        public bool Build()
        {
            Console.WriteLine("Фундамент залит");
            return true;
        }
    }
}
