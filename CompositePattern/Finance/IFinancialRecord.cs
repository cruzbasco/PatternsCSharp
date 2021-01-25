using System;

namespace CompositePattern.Finance
{
    public interface IFinancialRecord
    {

        string Title { get; set; }

        int Total { get; set; }

        void ShowBalance(int tab)
        {
            string tabs = new string('\t', tab);

            Console.WriteLine($"{tabs}Title = {Title} : Total = {Total}");
        }
    }
}
