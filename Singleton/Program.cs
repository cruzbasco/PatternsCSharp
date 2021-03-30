using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {

            var a1 = new ClassA("a1");
            var a2 = new ClassA("a2");
            var a3 = new ClassA("a3");

            var c1 = new ClassC("c1");
            var c2 = new ClassC("c2");

            var b1 = new ClassB("b1");

            var config = Config.Instance();
            Console.WriteLine(config.Message);
        }

    }

    public class Config
    {
        private static readonly Config _instance = new();

        public string Message { get; set; } = "";

        private Config()
        {
            Console.WriteLine("Hello World!");
        }

        public static Config Instance()
        {
            return _instance;
        }

    }



    public class ClassA
    {
        private Config config = Config.Instance();

        public ClassA(string message)
        {
            config.Message += message;
        }
    }


    public class ClassB
    {
        private Config config = Config.Instance();

        public ClassB(string message)
        {
            config.Message += message;
        }
    }
    public class ClassC
    {
        private Config config = Config.Instance();

        public ClassC(string message)
        {
            config.Message += message;
        }
    }

}