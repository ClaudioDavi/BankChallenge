using System;

namespace BankChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Claudio", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} U$$");
        }
    }
}
