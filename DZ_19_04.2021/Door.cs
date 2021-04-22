using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class Door : IPart
    {
        public Door() { }
        public bool BuildDoors(int count)
        {
            for(int i = 0;i < count; ++i)
            {
                if(Build() == false)
                    return false;     
            }
            Console.WriteLine($"Построено {count} дверей");
            return true;
        }
        public bool Build()
        {
            Console.WriteLine("Дыерь построена");
            return true;
        }
    }
}
