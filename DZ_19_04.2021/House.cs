using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class House
    {
        public List<IPart> mass = new List<IPart>();
        public House()
        {
            mass.Add(new Basement());
            mass.Add(new Walls());
            mass.Add(new Door());
            mass.Add(new Window());
            mass.Add(new Roof());
        }
        public bool BuildBasement()
        {
            Basement temp = new Basement();
            if(temp.Build() == true)
                return true;
            return false;
        }
        public bool BuildWalls(int count)
        {
            Walls temp = new Walls();
            if (temp.BuildWalls(count) == true)
                return true;
            return false;
        }
        public bool BuildWindows(int count)
        {
            Window temp = new Window();
            if (temp.BuildWindows(count) == true)
                return true;
            return false;
        }
        public bool BuildDoor(int count)
        {
            Door temp = new Door();
            if (temp.BuildDoors(count) == true)
                return true;
            return false;
        }
        public bool BuildRoof()
        {
            Roof temp = new Roof();
            if (temp.Build() == true)
                return true;
            return false;
        }
        public void DrawHouse()
        {

        }
        
    }
}
