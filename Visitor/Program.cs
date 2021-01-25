using System;
using Visitor.Discount;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {

            /* problema
             * implementar funcionalidad extra al catalogo
             */

            IProduct dell = new Laptop("Dell", 2000);
            IProduct mac = new Laptop("MacBook", 3000);
            IProduct toshiba = new Laptop("Toshiba", 1500);

            IProduct lotr = new Book("Lord of the Rings", 60);
            IProduct got = new Book("Game of Thrones", 20);
            IProduct hp = new Book("Harry Potter Collection", 150);
            IProduct narnia = new Book("Chronicles of Narnia", 70);

            IProduct bread = new Food("Bread", 8);
            IProduct meat = new Food("Meat", 40);
            IProduct chicken = new Food("Chicken", 25);

            var catalog = new Catalog();
            catalog.Add(dell);
            catalog.Add(mac);
            catalog.Add(toshiba);
            catalog.Add(lotr);
            catalog.Add(got);
            catalog.Add(hp);
            catalog.Add(narnia);

            catalog.Add(bread);
            catalog.Add(meat);
            catalog.Add(chicken);


            IDiscount standardDiscount = new StantardPromotion();
            IDiscount bfDiscount = new BlackFridayPromotion();
            IDiscount noDiscount = new NoPromotion();

            catalog.GetDiscount(standardDiscount);
            catalog.GetDetails();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            catalog.GetDiscount(bfDiscount);
            catalog.GetDetails();
         
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            catalog.GetDiscount(noDiscount);
            catalog.GetDetails();
        }
    }
}
