using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV2.Menu
{
    class HyperMaxiMenu : IMenu
    {
        private readonly HyperMaxi menu;

        public HyperMaxiMenu()
        {
            menu = new HyperMaxi();
        }
        public void Show()
        {
            menu.GetFruits();
        }
    }
}
