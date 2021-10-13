using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasSideCart { get; set; }
        public bool MakesNoise { get; set; }
        
        public override void DriveAbstract()
        {
            Console.WriteLine("I love this Vehicle!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("I drive this vehicle");
        }
    }
}