using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Controler
    {
        public List<Flor> flors;

        public void GennemløbForStaff(Staff staff)
        {

        }
        public Controler(List<Flor> flors)
        {
            this.flors = flors;
        }

        public Controler()
        {

        }
        public void GennemløbForStaff(Staff staff)
        {

        }

        public void ForetagScanning(Staff staff)
        {
            if (staff.MyFlor.MyScanner.Scan(staff))
            {


            }
            else
            {
                Console.WriteLine(staff.MyFlor.MyTurret.Kill(staff));
                //Nak ham
            }


        }


    }
}
