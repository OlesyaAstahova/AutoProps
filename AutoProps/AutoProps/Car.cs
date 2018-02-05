using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
       // private string carName = "";
        public int Speed { get; set; }
        public string Color { get; set; } 
        public string PetName
        {
            get; set;
           // get { return carName; }
           // set { carName = value;]}
        }
        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
