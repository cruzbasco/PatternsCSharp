using Decorator.Travels;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // una agencia de viajes necesita promocionar viajes y vender paquetes 

            Solucion();

        }

        private static void Solucion()
        {
            ITour cochaTour = new Tour("cochabamba tour", 350);

            ITour viajePareja = new CoupleTour();

            IPackage tunariWalk = new Walk(viajePareja, "tunari walk", 80);

            IPackage casaDeCampoDinner = new Dinner(tunariWalk, "casa de campo", 250);

            IPackage chikensDinner = new Dinner(casaDeCampoDinner, "chikens ", 1550);

            IPackage cristoTourGuide = new TouristGuide(chikensDinner, "cristo tour guide", 50);

            Console.WriteLine(cristoTourGuide.ShowDetails());

            Console.WriteLine($"total cost: {cristoTourGuide.Total()}");
        }
    }
}
