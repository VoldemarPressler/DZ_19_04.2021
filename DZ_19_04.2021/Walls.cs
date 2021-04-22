using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class Walls:IPart
    {
        public bool BuildWalls(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                if (Build() == false)
                    return false;
            }
            Console.WriteLine($"Стен {count} построено");
            return true;
        }
        public bool Build()
        {
            Console.WriteLine("Стена построена");
            return true;
        }
    }
}
