using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        public static void Main(string[] args)
        {
            // neavr izveidot , jo Vehicle ir abstract classe
            // var vehicle = new Vehicle();
            // vehicle.Name = "Audi";
            // vehicle.IncreaseSpeed();


            var car = new Car();
            car.Name = "BMW";
            car.IncreaseSpeed();
            car.StartToDrive();

            var ship = new Ship();
            ship.Name = "Baltica";
            ship.IncreaseSpeed();
            ship.SetSail();

            SoundHorn3Times(car);
            SoundHorn3Times(ship);

            


            Console.ReadLine();

        }

        public static void SoundHorn3Times(Vehicle vehicle) {
            vehicle.SoundHorn();
            vehicle.SoundHorn();
            vehicle.SoundHorn();
            //can call
            vehicle.StartMoving();


        }
    }
}
