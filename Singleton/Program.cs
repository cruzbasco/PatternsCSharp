using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            var a1 = new ClassA("a1");
            var a2 = new ClassA("a2");
            var a3 = new ClassA("a3");

            var c1 = new ClassC("c1");
            var c2 = new ClassC("c2");

            var b1 = new ClassB("b1");


            Console.WriteLine(Config.Message);
        }
    }


    public static class Config
    {
        public static string Message { get; set; }
    }



    public class ClassA
    {
        public ClassA(string message)
        {
            Config.Message += message;
        }
    }


    public class ClassB
    {
        public ClassB(string message)
        {
            Config.Message += message;
        }
    }
    public class ClassC
    {
        public ClassC(string message)
        {
            Config.Message += message;
        }
    }

}
