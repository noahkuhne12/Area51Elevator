using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Controler
    {
        public List<Flor> flors;

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
            Console.WriteLine("Scanning ind Progres");
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
