using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV1
{
    class Facade
    {
        private readonly ChickenFingers effens;
        private readonly Panchita panchita;
        private readonly Dumbo dumbo;
        private readonly Zelada zelada;
        private readonly HyperMaxi hypermaxi;

        public Facade()
        {
            effens = new ChickenFingers();

            panchita = new Panchita();

            dumbo = new Dumbo();

            zelada = new Zelada();

            hypermaxi = new HyperMaxi();
        }

        public void Show()
        {

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
