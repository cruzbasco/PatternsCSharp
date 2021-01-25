using System;
using System.Threading;
using Maze.Logic.Iterator;

namespace Maze.Console
{
    public class Program
    {
        public static Maze.Logic.Iterator.Maze maze;
        static void Main(string[] args)
        {
            maze = new Maze.Logic.Iterator.Maze(4);

            maze.Load();

            foreach (var row in maze.Print())
            {
                System.Console.WriteLine(row);
            }
            System.Console.WriteLine("\n\n");



            Iterator iterator = maze.CreateIterator();

            System.Console.WriteLine("\n\n");


            for (Square square = iterator.First(); iterator.IsDone; iterator.Next())
            {
                System.Console.WriteLine(square.Symbol);
            }
            System.Console.WriteLine("\n\n");


            foreach (var row in maze.Print())
            {
                System.Console.WriteLine(row);
            }
        }

        static void Countdown()
        {
            Iterator iterator = maze.CreateIterator();

            var timer = new Timer(TimeCallBack, null, 1000, 1000);

            var first = iterator.First();

            void TimeCallBack(object state)
            {
                if (iterator.IsDone)
                {
                    iterator.Next();
                }
            }
        }

   
    }
}
