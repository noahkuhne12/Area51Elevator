using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Turret
    {
        public Flor MyFlor;

        public Turret()
        {

        }

        public Turret(Flor myFlor)
        {
            MyFlor = myFlor;
        }

        public string Kill(Staff staff)
        {
            staff.Dead = true;
            return "He dead";
        }
    }
}
