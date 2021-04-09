using Bridge.FuelType;
using Bridge.Transport;
using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IFuelType gasoline = new Gasoline();
            IFuelType diesel = new Diesel();
            IFuelType hybrid = new Hybrid();
            IFuelType electric = new Electric();


            ITransport car = new Car(gasoline);
            ITransport truck = new Truck(diesel);
            ITransport train = new Train(electric);



            car.CalculateMaxRange();
            truck.CalculateMaxRange();
            train.CalculateMaxRange();

        }

    }
}
