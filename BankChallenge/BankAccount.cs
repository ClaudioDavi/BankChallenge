using System;
using System.Collections.Generic;
namespace BankChallenge
{
    public class BankAccount
    {
        public decimal Balance {
            get {
                decimal balance = 0;
                foreach (var item in allTransactions) {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        public string Owner {get; set;}
        public string Number {get; set;}

        private static int accountNumberSeed = 3345210;
        private List<Transaction> allTransactions = new List<Transaction>();        
        
        public BankAccount(string name, decimal initialBalance) {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            accountNumberSeed++;
        }
        
        public void MakeDeposit (decimal amount, DateTime date, string note) {
            if(amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid amount to deposit");
            }
            allTransactions.Add(new Transaction(amount, date, note));
        }

        public void MakeWithdraw (decimal amount, DateTime date, string note) {
            if(amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid Amount to Withdraw");
            }
            if (Balance - amount < 0) {
                throw new InvalidOperationException("Not sufficient funds");    
            }
            allTransactions.Add(new Transaction((amount * -1), date, note));
        }
    }
}