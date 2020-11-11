using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Staff
    {
        public Flor MyFlor, TargetFlor;
        public bool Dead = false;
        public int Clearance;
        public int SpawnTime;

        public Staff(Flor myFlor, Flor targetFlor, int clearance, int spawnTime)
        {
            MyFlor = myFlor;
            TargetFlor = targetFlor;
            Clearance = clearance;
            SpawnTime = spawnTime;
        }
    }
}
