using System;
using System.Collections.Generic;

namespace Maze.Logic.Iterator
{
    public class Square
    {
        public char Symbol { get; set; }
        public bool IsChecked { get; set; }
        public string Color { get; set; }

        public List<string> colors = new List<string> { "FireBrick", "Lime", "DarkOrange", "DodgerBlue", "Violet", "Yellow" };

        public Square()
        {
            Symbol = ' ';
            IsChecked = false;
            Color = "black";
        }

        public void Checked(int index)
        {
            IsChecked = true;
            Symbol = Symbol.ToString().ToUpper()[0];
            Color = colors[index];
        }

        public void ToLower()
        {
            Symbol = Symbol.ToString().ToLower()[0];
            Color = "black";
        }

    }

}
