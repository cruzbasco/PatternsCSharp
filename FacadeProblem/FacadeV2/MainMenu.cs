using FacadeProblem.FacadeV2.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem.FacadeV2
{
    public class MainMenu
    {
        private readonly Facade menu;

        public MainMenu()
        {
            menu = new Facade();

            MenuParticipants();
        }

        public void MenuParticipants()
        {
            menu.Add(new ChickenFingersMenu());
            menu.Add(new PanchitaMenu());
            menu.Add(new ZeladaMenu());
            menu.Add(new DumboMenu());
            menu.Add(new HyperMaxiMenu());
            menu.Add(new CasaDeCampoMenu());
            menu.Add(new PropioMenu());
        }

        public void Show()
        {
            menu.Show();
        }
    }
}
