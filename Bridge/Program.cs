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


            //clases X funcionalidades 
            //    3  x  4    => 12

            //clases +  funcionalidades
            //    3  +  4    => 7


            //cuentas 
            //    ahorro
            //    ahorro plus
            //    corriente

            //nacionalidad
            //    nacional
            //    residente
            //    extranjero

            //salario
            //    bajo
            //    medio
            //    alto

            //tipo
            //    individuo
            //    empresa
            //    ong


            //    ahorro - nacional - bajo - individuo
            //    2 x 3 x 3 x 2 = 36
            //    2 x 3 x 3 x 3 = 54

            //cuenta (nacionalidad, salario, tipo)

        }

    }
}
