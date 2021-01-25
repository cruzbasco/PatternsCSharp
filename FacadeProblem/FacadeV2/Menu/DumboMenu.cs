using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV2.Menu
{
    class DumboMenu : IMenu
    {
        private readonly Dumbo menu;

        public DumboMenu()
        {
            menu = new Dumbo();
        }
        public void Show()
        {
            menu.GetIceCreams();
            menu.GetCakes();
            menu.GetDesserts();
        }
    }
}
