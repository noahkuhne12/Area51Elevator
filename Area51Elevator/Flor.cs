using System;
using System.Collections.Generic;
using System.Text;

namespace Area51Elevator
{
    class Flor
    {
        public int SecrecyLevel;
        public Scanner MyScanner;
        public Turret MyTurret;
        public Panel MyPanel;

        public void TrykPåPanel(Staff staff)
        {
            MyPanel.Klik(staff);
        }
        public Flor()
        {

        }

        public Flor(int secrecyLevel, Controler mycontroler)
        {
            SecrecyLevel = secrecyLevel;
            MyScanner = new Scanner(this);
            MyTurret = new Turret(this);
            MyPanel = new Panel(this, mycontroler);
        }

        
    }
}
