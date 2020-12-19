using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rovers.Model
{
    class Rover
    {
        private int positionX;

        private int positionY;

        private string compassHeading; 

        public int PositionX 
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int PositionY
        {   
            get { return positionY; }
            set { positionY = value; }
        }

        public string CompassHeading
        {
            get { return compassHeading; }
            set { compassHeading = value; }
        }
    }
}
