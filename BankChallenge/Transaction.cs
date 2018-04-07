using System;

namespace BankChallenge
{
    public class Transaction
    {
        public decimal Amount {get;}
        public DateTime Date {get;}
        public String Notes {get;}

        public Transaction (decimal amount, DateTime date, string note) {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}