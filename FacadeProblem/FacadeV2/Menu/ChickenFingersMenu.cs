using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV2.Menu
{
    class ChickenFingersMenu : IMenu
    {
        private readonly ChickenFingers chickenFingers;

        public ChickenFingersMenu()
        {
            chickenFingers = new ChickenFingers();

        }
        public void Show()
        {
            chickenFingers.ShowMenu();
        }
    }
}
