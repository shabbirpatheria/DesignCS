using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignCS.src.OopPrinciples.Composition
{
    public class Car
    {
        private Engine engine = new Engine();
        private Wheels wheels= new Wheels();
        private Chasis chasis= new Chasis();
        private Seats seats= new Seats();

        public void StartCar(){
            engine.Start();
            wheels.Rotate();
            chasis.Support();
            seats.Sit();
        }
        
    }
}