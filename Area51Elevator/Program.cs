using System;
using System.Collections.Generic;

namespace Area51Elevator
{
    class Program
    {
        List<Flor> flors;
        List<Staff> Staffs = new List<Staff>();
        Controler ctlr = new Controler();

        public Program()
        {

            flors = new List<Flor>()
            {
                new Flor(0,ctrl),
                new Flor(1,ctrl),
                new Flor(2,ctrl),
                new Flor(3,ctrl),
            };

            for (int i = 0; i < 1; i++)
            {
                Staffs.Add(
                    new Staff(flors[RND.Range(0, flors.Count)],
                    flors[RND.Range(0, flors.Count)],
                    RND.Range(0, flors.Count),
                    ));
            }
        }

        public void GennemLøb(Staff staff)
        {
            staff.MyFlor.TrykPåPanel(staff);
        }


        static void Main(string[] args)
        {
            //p.panel.SendrequestToController();
            Program p = new Program();
            p.GennemLøb(p.Staffs[0]);



        }
    }
}
