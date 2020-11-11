using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Scanner
    {
        public Flor MyFlor;

        public Scanner(Flor myFlor)
        {
            MyFlor = myFlor;
        }

        public bool Scan(Staff staff)
        {
            if (staff.Clearance >= staff.MyFlor.SecrecyLevel)
            {
                return true;
            }
            return false;
        }
    }
}
