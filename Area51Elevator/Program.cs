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
                new Flor(1,ctlr),
                new Flor(2,ctlr),
                new Flor(3,ctlr),
                new Flor(4,ctlr),
            };

            for (int i = 0; i < 1; i++)
            {
                Staffs.Add(
                    new Staff(flors[RND.Range(0, flors.Count)],
                    flors[RND.Range(0, flors.Count)],
                    RND.Range(0, flors.Count),
                    RND.Range(0,100)));
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
            for (int i = 0; i < p.Staffs.Count; i++)
            {
                p.GennemLøb(p.Staffs[i]);
            }
            



        }
    }
}
