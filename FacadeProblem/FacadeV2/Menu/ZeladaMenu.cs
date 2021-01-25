using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV2.Menu
{
    public class ZeladaMenu : IMenu
    {
        private readonly Zelada menu;

        public ZeladaMenu()
        {
            menu = new Zelada();
        }
        public void Show()
        {
            menu.Shop();
            // remover los precios
        }

        public void RemovePriceTag()
        {

        }
    }
}
