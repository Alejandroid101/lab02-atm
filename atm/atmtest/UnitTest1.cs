using System;
using Xunit;
using static atm.Program;

namespace atmtest
{
    public class UnitTest1
    {
        //The next 2 tests run valid amounts, therefore the transactions go through.
        //Having set a global variable for my balance, it gets affected after each test
        //
        [Fact]
        public void TestDepo()
        {
            int balance = atm.Program.Balance;
            Assert.Equal(balance+ 1000, Deposit(1000));
        }
        [Fact]
        public void TestWith()
        {
            int balance = atm.Program.Balance;
            Assert.Equal(balance- 4000, Withdraw(4000));
        }
        
        //The next 2 tests run invalid amounts, therefore the balance should not be affected
        [Fact]
        public void TestDepoNeg()
        {
            int balance = atm.Program.Balance;
            Assert.Equal(balance, Deposit(-200));
        }
        [Fact]
        public void TestWithMore()
        {
            int balance = atm.Program.Balance;
            Assert.Equal(balance, Withdraw(10000));
        }
    }
}
