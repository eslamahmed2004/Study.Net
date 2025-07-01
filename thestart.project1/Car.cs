using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thestart.project1
{
     class Car
    {
        
        public string color ="";
        //public DateTime DateOfBirth;
        public int Maxspeed ;
        public Car() { }
       public Car(String color, int Maxspeed)
        {
            this.color = color;
            this.Maxspeed = Maxspeed;

        }
        public int maxspeed(int Maxspeed)
        {
            return (Maxspeed * 20) / 8;
        }

    }
}
