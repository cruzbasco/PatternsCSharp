using CompositePattern.Finance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var plomero = new Record("plomero", 2_500);
            var pintor = new Record("pintor", 2_000);
            var carpintero = new Record("carpintero", 3_540);
            var electricista = new Record("electricista", 5_100);

            var luz = new Record("luz", 14_230);
            var agua= new Record("agua", 9_000);
            var internet = new Record("internet", 1_500);

            var portero = new Record("portero", 3_000);
            var limpieza = new Record("limpieza", 2_500);
            var administrador = new Record("administrador", 5_000);


            var mantenimiento = new ComplexRecord("mantenimiento");
            var servicios = new ComplexRecord("servicios");
            var personal = new ComplexRecord("personal");

            var edificio = new ComplexRecord("edificio");

            var ps5 = new Record("ps5", 4_000);

            mantenimiento.AddRecord(plomero);
            mantenimiento.AddRecord(pintor);
            mantenimiento.AddRecord(carpintero);
            mantenimiento.AddRecord(electricista);

            servicios.AddRecord(luz);
            servicios.AddRecord(agua);
            servicios.AddRecord(internet);

            personal.AddRecord(portero);
            personal.AddRecord(limpieza);
            personal.AddRecord(administrador);

            edificio.AddRecord(mantenimiento);
            edificio.AddRecord(servicios);
            edificio.AddRecord(personal);


            mantenimiento.AddRecord(ps5);
            personal.AddRecord(plomero);

            edificio.ShowBalance(0);

            Console.WriteLine("///////////////////");
            Console.WriteLine("///////////////////");
            Console.WriteLine("///////////////////");

            edificio.RemoveRecordInDepth("ps5");
            personal.RemoveRecord("plomero");

            edificio.ShowBalance(0);

            Console.WriteLine($"total = {edificio.Total}");


        }
    }
}
