namespace Decorator.Travels
{
    public interface ITour
    {
        string ShowDetails();
        float Total();
        int People { get; }
        
    }

    public class Tour : ITour
    {
        private readonly string name;
        private readonly float price;
        public int People { get; } = 1;

        public Tour(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public string ShowDetails()
        {
            return $"Travel to {name} ";
        }

        public float Total()
        {
            return price;
        }
    }

    public class CoupleTour : ITour
    {
        public int People { get; } = 2;

        public string ShowDetails()
        {
            return "viaje en  pareja";
        }

        public float Total()
        {
            return 1000;
        }
    }

    public interface IPackage : ITour
    {
        ITour Tour { get; }
    }

    public class Walk : IPackage
    {
        private readonly string name;
        private readonly float price;

        public ITour Tour { get; }

        public int People { get; }

        public Walk(ITour travel, string name, float price)
        {
            Tour = travel;
            this.name = name;
            this.price = price;
            People = travel.People;

        }

        public string ShowDetails()
        {
            return Tour.ShowDetails() + $"+ Walk to {name} ";
        }

        public float Total()
        {
            return Tour.Total() + price;
        }
    }

    public class Dinner : IPackage
    {
        private readonly string name;
        private readonly float price;

        public ITour Tour { get; }

        public int People { get; }

        public Dinner(ITour travel, string name, float price)
        {
            Tour = travel;
            this.name = name;
            this.price = price;

            People = travel.People;
        }

        public string ShowDetails()
        {
            return Tour.ShowDetails() + $"+ dinner at {name} ";
        }

        public float Total()
        {
            return Tour.Total() + CalcDinnerPerPerson();
        }

        private float CalcDinnerPerPerson()
        {
            return price * Tour.People;
        }
    }

    public class TouristGuide : IPackage
    {
        private readonly string name;
        private readonly float price;

        public ITour Tour { get; }

        public int People { get; }

        public TouristGuide(ITour travel, string name, float price)
        {
            Tour = travel;
            this.name = name;
            this.price = price;
            People = travel.People;

        }
        public string ShowDetails()
        {
            return Tour.ShowDetails() + $"+ tourist guide to {name} ";
        }


        public float Total()
        {
            return Tour.Total() + price;
        }
    }
}
