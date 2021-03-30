using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FacadeProblem.FacadeV2
{
    public class Facade
    {
        private readonly IList<IMenu> menus = new List<IMenu>();

        public void Add(IMenu newMenu)
        {
            menus.Add(newMenu);
        }

        public void Show()
        {
            foreach (var menu in menus)
            {
                menu.Show();
            }
        }

    }
}
