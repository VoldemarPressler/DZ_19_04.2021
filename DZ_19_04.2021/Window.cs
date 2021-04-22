using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class Window : IPart
    {
        public bool BuildWindows(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                if (Build() == false)
                    return false;
            }
            Console.WriteLine($"Установлено {count} окон");
            return true;
        }
        public bool Build()
        {
            Console.WriteLine("Окно установлено");
            return true;
        }
    }
}
