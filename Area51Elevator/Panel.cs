using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Panel
    {
        public Flor MyFlor;
        public Controler MyController;

        public Panel(Flor myFlor, Controler ctrl)
        {
            MyFlor = myFlor;
            MyController = ctrl;
        }

        public void Klik(Staff staff)
        {
            MyController.ForetagScanning(staff);

        }
    }
}
