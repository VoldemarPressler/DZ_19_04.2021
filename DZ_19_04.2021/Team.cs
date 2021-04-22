using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_19_04._2021
{
    class Team:IWorker
    {
        private int CountDoor;
        private int CountWalls;
        private bool Roof;
        private bool Basement;
        private int CountWindows;
        public void BuildHouse()
        {
            Door a = new Door();   
            House temp = new House();
            foreach(IPart i in temp.mass)
            {
                if(i is Basement)
                {
                    Basement bas = i as Basement;
                    bas.Build();
                    Basement = true;
                }
                else if (i is Door)
                {
                    if (CountWalls != 4)
                        throw new Exception("Предыдущий пункт не выполнен");
                    Door dor = i as Door;
                    dor.BuildDoors(1);
                    CountDoor = 1;
                }
                else if (i is Walls)
                {
                    if (Basement == false)
                        throw new Exception("Предыдущий пункт не выполнен");
                    Walls wal = i as Walls;
                    wal.BuildWalls(4);
                    CountWalls = 4;
                }
                else if (i is Window)
                {
                    if (CountWalls != 4)
                        throw new Exception("Предыдущий пункт не выполнен");
                    Window win = i as Window;
                    win.BuildWindows(4);
                    CountWindows = 4;
                }
                else if (i is Roof)
                {
                    if (CountWindows != 4)
                        throw new Exception("Предыдущий пункт не выполнен");
                    Roof rof = i as Roof;
                    rof.Build();
                    Roof = true;
                }
               
            }

        }
    }
}
