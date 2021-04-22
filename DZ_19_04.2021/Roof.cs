using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class Roof:IPart
    {
        public bool Build()
        {
            Console.WriteLine("Крыша сделана");
            return true;
        }
    }
}
