using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25_01
{
    public class Worker : IWorker
    {
        public void Work(House house)
        {
            if (!house.Basement.IsBuilt)
            {
                house.Basement.IsBuilt = true;
            }
            if (!house.WallFirst.IsBuilt && !house.WallSecond.IsBuilt)
            {
                house.WallFirst.IsBuilt = true;
                house.WallSecond.IsBuilt = true;
            }
            if (!house.WallThird.IsBuilt && !house.WallFourth.IsBuilt)
            {
                house.WallThird.IsBuilt = true;
                house.WallFourth.IsBuilt = true;
            }
            if (!house.Door.IsBuilt)
            {
                house.Door.IsBuilt = true;
            }
            if (!house.WindowFirst.IsBuilt && !house.WindowSecond.IsBuilt)
            {
                house.WindowFirst.IsBuilt = true;
                house.WindowSecond.IsBuilt = true;
            }
            if (!house.WindowThird.IsBuilt && !house.WindowFourth.IsBuilt)
            {
                house.WindowThird.IsBuilt = true;
                house.WindowFourth.IsBuilt = true;
            }
            if (!house.Roof.IsBuilt)
            {
                house.Roof.IsBuilt = true;
            }
        }
    }
}
