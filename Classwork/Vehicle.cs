using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void StartMoving();
        public void IncreaseSpeed()
        {

        }
        public virtual void SoundHorn() {
            Console.WriteLine("beep beep");
        }

    }


    public class Car : Vehicle 
    {
        public override void StartMoving() {
            Console.WriteLine("Car is starting to move");
        }
        public void StartToDrive() 
        { 
        
        }

    }

    public class Ship : Vehicle
    {

        public override void StartMoving()
        {
            Console.WriteLine("Ship  is setting sale");
        }
        public void SetSail()
        {

        }

        public override void SoundHorn()
        {
            Console.WriteLine("Tuuu tuu");
        }
    }
}
