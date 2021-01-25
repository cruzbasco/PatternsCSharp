using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV2.Menu
{
    public class PanchitaMenu : IMenu
    {
        private readonly Panchita menu;

        public PanchitaMenu()
        {
            menu = new Panchita();
        }
        public void Show()
        {
            Console.WriteLine(menu.Menu());
        }
    }
}
