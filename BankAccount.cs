using System;
using System.Collections.Generic;
namespace C_
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
            accountNumberSeed++;
        }
        
        public void MakeDeposit (decimal amount, DateTime date, string note) {
            
        }
        public void MakeWithdraw (decimal amount, DateTime date, string note) {

        }
    }
}