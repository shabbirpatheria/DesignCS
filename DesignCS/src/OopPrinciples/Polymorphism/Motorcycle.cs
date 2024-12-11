using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignCS.src.OopPrinciples.Polymorphism
{
    public class Motorcycle: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is Starting");
        }
        public override void Stop(){
            Console.WriteLine("Motocycle is Stopping");
        }
    }
}