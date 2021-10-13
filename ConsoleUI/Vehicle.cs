using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Unknown";
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";

        public abstract void DriveAbstract();
       
        public virtual void DriveVirtual() 
        {
            Console.WriteLine("I drive this vehicle {Make}, {Model}, {Year}");
        }
        
         

     
        

    }
}
