using System;

namespace CompositePattern.Finance
{
    public class Record : IFinancialRecord
    {
        private string _title;
        private int _balance;

        public string Title { get => _title; set => throw new NotImplementedException(); }
        public int Total { get => _balance; set => throw new NotImplementedException(); }

        public Record(string title, int balance)
        {
            _title = title;
            _balance = balance;
        }
    }
}
