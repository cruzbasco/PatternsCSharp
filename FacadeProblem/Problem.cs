using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem
{
    class Problem
    {
        public Problem()
        {
            /*
             en un congreso se pide elaborar un menu para todos los participantes 
             
             */


            var effens = new ChickenFingers();

            var panchita = new Panchita();

            var dumbo = new Dumbo();

            var zelada = new Zelada();

            var hypermaxi = new HyperMaxi();



            // menu

            effens.ShowMenu();

            Console.WriteLine(panchita.Menu());

            dumbo.GetIceCreams();
            dumbo.GetCakes();
            dumbo.GetDesserts();

            zelada.Shop();

            hypermaxi.GetFruits();

        }

    }
}
