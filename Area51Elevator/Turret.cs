using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Turret : ITakeTime
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
            ITakeTime.TakeTime();
            staff.Dead = true;
            return "dead boy or gril";
        }
    }
}
