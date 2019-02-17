using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25_01
{
    public class TeamLeader : IWorker
    {
        public bool AllIsBuilt { get; set; }
        public void Work(House house)
        {
            if (house.Basement.IsBuilt && house.Roof.IsBuilt && house.Door.IsBuilt)
            {
                if (house.WallFirst.IsBuilt && house.WallSecond.IsBuilt && house.WallThird.IsBuilt && house.WallFourth.IsBuilt)
                {
                    if (house.WindowFirst.IsBuilt && house.WindowSecond.IsBuilt && house.WindowThird.IsBuilt && house.WindowFourth.IsBuilt)
                    {
                        AllIsBuilt = true;
                    }
                }
            }
            else
            {
                Console.WriteLine(Report(house));
            }
        }
        public string Report(House house)
        {
            bool wallsIsBuilt = false;
            bool windowsIsBuilt = false;
            if (house.WallFirst.IsBuilt && house.WallSecond.IsBuilt && house.WallThird.IsBuilt && house.WallFourth.IsBuilt)
            {
                if (house.WindowFirst.IsBuilt && house.WindowSecond.IsBuilt && house.WindowThird.IsBuilt && house.WindowFourth.IsBuilt)
                {
                    windowsIsBuilt = true;
                }
                wallsIsBuilt = true;
            }

            return $"Basement : {house.Basement.IsBuilt}\nWalls : {wallsIsBuilt}\nWindows : {windowsIsBuilt}\nDoor : {house.Door.IsBuilt} \nRoof : {house.Door.IsBuilt}";
        }
    }
}
