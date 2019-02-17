using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25_01
{
    public class Team
    {
        IWorker worker;
        TeamLeader teamLeader;
        House house;
        public Team()
        {
            worker = new Worker();
            teamLeader = new TeamLeader();
            house = new House();
        }
        public void StartWork()
        {
            teamLeader.Work(house);
            worker.Work(house);
            teamLeader.Work(house);
            if (teamLeader.AllIsBuilt)
            {
                house.PaintHouse();
            }
        }
    }
}
