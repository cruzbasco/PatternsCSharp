namespace Visitor.Discount
{
    public interface IDiscount
    {
        decimal GetDiscount(Laptop laptop);
        decimal GetDiscount(Book book);
        decimal GetDiscount(Food food);
    }

    public class NoPromotion : IDiscount
    {
        public decimal GetDiscount(Laptop laptop)
        {
            return 0;
        }

        public decimal GetDiscount(Book book)
        {
            return 0;
        }

        public decimal GetDiscount(Food food)
        {
            return 0;
        }
    }

    public class StantardPromotion : IDiscount
    {
        public decimal GetDiscount(Laptop laptop)
        {
            return laptop.GetPrice() * 0.10M;
        }

        public decimal GetDiscount(Book book)
        {
            return book.GetPrice() * 0.15M;
        }

        public decimal GetDiscount(Food food)
        {
            return food.GetPrice() * 0.05M;
        }
    }

    public class BlackFridayPromotion : IDiscount
    {
        public decimal GetDiscount(Laptop laptop)
        {
            return laptop.GetPrice() * 0.40M;
        }

        public decimal GetDiscount(Book book)
        {
            return book.GetPrice() * 0.60M;
        }

        public decimal GetDiscount(Food food)
        {
            return food.GetPrice() * 0.25M;
        }

    }
}
