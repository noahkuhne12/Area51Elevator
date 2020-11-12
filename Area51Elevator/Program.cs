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
            // Createing floors
            flors = new List<Flor>()
            {
                new Flor(1,ctlr),
                new Flor(2,ctlr),
                new Flor(3,ctlr),
                new Flor(4,ctlr),
            };


            // creating Staff
            int numberOfStaff;

            Console.WriteLine("How many pepel in do you ned in staff");
            numberOfStaff = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfStaff; i++)
            {
                Staffs.Add(
                    new Staff(flors[RND.Range(0, flors.Count)],
                    flors[RND.Range(0, flors.Count)],
                    RND.Range(0, flors.Count),
                    RND.Range(0,50)));
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

            int timer = 0;

            while (timer != 50)
            {
                for (int i = 0; i < p.Staffs.Count; i++)
                {
                    if (p.Staffs[i].SpawnTime == timer)
                    {
                        p.GennemLøb(p.Staffs[i]);
                    }
                }
                Console.WriteLine(timer);
                ITakeTime.TakeTime();
                timer++;
            }
        }
    }
}
