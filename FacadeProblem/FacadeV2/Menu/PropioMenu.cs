using System;

namespace FacadeProblem.FacadeV2
{
    internal class PropioMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("pan con queso");
            Console.WriteLine("pan con mermelada");
            Console.WriteLine("bebidas");

        }
    }
}