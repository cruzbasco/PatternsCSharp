using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Finance
{
    public class ComplexRecord : IFinancialRecord
    {
        private string _title;
        private IList<IFinancialRecord> records;

        public string Title { get => _title; set => throw new NotImplementedException(); }
        public int Total { get => Calculate(); set => throw new NotImplementedException(); }

        public ComplexRecord(string title)
        {
            _title = title;
            records = new List<IFinancialRecord>();
        }

        private int Calculate()
        {
            return records.Sum(r => r.Total);
        }

        public void ShowBalance(int tab)
        {

            string tabs = new string('\t', tab);

            Console.WriteLine($"{tabs}Title = {Title} : Total = {Total}");

            foreach (var r in records)
            {
                r.ShowBalance(tab + 1);
            }
        }

        public void AddRecord(IFinancialRecord record)
        {
            records.Add(record);
        }

        public void RemoveRecord(string title)
        {
            var record = records.FirstOrDefault(r => r.Title == title);
            records.Remove(record);
        }

        public void RemoveRecordInDepth(string title)
        {
            RemoveRecord(title);

            foreach (var r in records)
            {
                if (r is ComplexRecord)
                {
                    ((ComplexRecord)r).RemoveRecordInDepth(title);
                }
            }
        }

    }

}
