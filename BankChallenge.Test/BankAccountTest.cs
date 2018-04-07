    using System;
    using Xunit;
    using BankChallenge;

    namespace BankChallenge.Test {
        
        public class BankAccountTest {
            
            [Fact]
            public void Test_Deposit() {
                decimal expectedBalance = 200;
                decimal deposit = 100;
                var account = new BankAccount("Claudio", 100);
                account.MakeDeposit(deposit,DateTime.Now, "");
                Assert.Equal(expectedBalance, account.Balance);
            }

            [Fact]
            public void Test_Withdraw() {
                decimal expectedBalance  = 300;
                decimal withdraw = 250;
                var account = new BankAccount("Claudio", 550);
                
                account.MakeWithdraw(withdraw, DateTime.Now, "");
                Assert.Equal(expectedBalance, account.Balance);
            }

            [Theory]
            [InlineData(200)]
            [InlineData(150)]
            public void Test_Withdrow_OutOfBalance(decimal value) {
                var account = new BankAccount("Claudio", 50);

                Exception _result = Assert.Throws<InvalidOperationException>(
                    () => account.MakeWithdraw(value, DateTime.Now, "")
                );
            }

            [Theory]
            [InlineData(-1)]
            [InlineData(-20)]
            public void Test_Withdraw_Negative(decimal value) {
                var account = new BankAccount("Claudio", 1000);

                Exception _result = Assert.Throws<ArgumentOutOfRangeException>(
                        () => account.MakeWithdraw(value, DateTime.Now, "")
                    );
            }
        }
    }
