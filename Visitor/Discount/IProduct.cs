using System;
using System.Collections.Generic;

namespace Visitor.Discount
{
    public interface IProduct
    {
        void GetDetails();
        decimal GetPrice();
        decimal GetDiscount(IDiscount discount);
    }

    public class Catalog : IProduct
    {
        private decimal _price = 0;
        private decimal _discount = 0;
        private List<IProduct> products = new List<IProduct>();

        public void Add(IProduct product)
        {
            products.Add(product);
        }

        public void Delete(IProduct product)
        {
            products.Remove(product);
        }

        public void GetDetails()
        {
            Console.WriteLine("Full Catalog");
            foreach (var p in products)
            {
                p.GetDetails();
            }

            Console.WriteLine($"Discount: {_discount} $ \nTotal: {GetPrice() - _discount} $");
        }

        public decimal GetDiscount(IDiscount discount)
        {
            _discount = 0;
            foreach (var p in products)
            {
                _discount += p.GetDiscount(discount);
            }

            return _discount;
        }

        public decimal GetPrice()
        {
            _price = 0;
            foreach (var p in products)
            {
                _price += p.GetPrice();
            }

            return _price;
        }


    }

    public class Laptop : IProduct
    {
        private readonly string _name;
        private readonly decimal _price;

        private decimal _discount;
        private decimal _nodiscount;
        private decimal _standarddiscount;
        private decimal _bfdiscount;


        public Laptop(string name, decimal price)
        {
            this._name = name;
            this._price = price;
        }

        public void GetDetails()
        {
            Console.WriteLine($"\tFood: {_name} Price: {_price} $");
            Console.WriteLine($"\t\tPromotion discount: {_discount} $ Pay: {_price - _discount} $");
        }

        public decimal GetDiscount(IDiscount discount) //(int codDescuento)
        {
            _discount = discount.GetDiscount(this);

            // logica 
            /*
                switch (codDescuento){
                    1: _discount = _noDiscount;
                    break;
                    2:..
                }
             */
            return _discount;
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }

    public class Book : IProduct
    {
        private readonly string _name;
        private readonly decimal _price;
        private decimal _discount;

        public Book(string name, decimal price)
        {
            this._name = name;
            this._price = price;
        }

        public decimal GetDiscount(IDiscount discount)
        {
            _discount = discount.GetDiscount(this);
            return _discount;
        }

        public void GetDetails()
        {
            Console.WriteLine($"\tFood: {_name} Price: {_price} $");
            Console.WriteLine($"\t\tPromotion discount: {_discount} $ Pay: {_price - _discount} $");
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }

    public class Food : IProduct
    {
        private readonly string _name;
        private readonly decimal _price;
        private decimal _discount;

        public Food(string name, decimal price)
        {
            this._name = name;
            this._price = price;
        }

        public decimal GetDiscount(IDiscount discount)
        {
            _discount = discount.GetDiscount(this);
            return _discount;
        }

        public void GetDetails()
        {
            Console.WriteLine($"\tFood: {_name} Price: {_price} $");
            Console.WriteLine($"\t\tPromotion discount: {_discount} $ Pay: {_price - _discount} $");
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }
}
