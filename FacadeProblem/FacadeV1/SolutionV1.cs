using FacadeProblem.FacadeV1;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProblem
{
    class SolutionV1
    {
        public SolutionV1()
        {
            /*
             en un congreso se pide elaborar un menu para todos los participantes 
             
             */


            var unifiedMenu = new Facade();

            unifiedMenu.Show();

        }

    }
}
