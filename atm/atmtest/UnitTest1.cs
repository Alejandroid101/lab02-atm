using System;
using Xunit;
using static atm.Program;

namespace atmtest
{
    public class UnitTest1
    {
        [Fact]
        public void Testicle1()
        {
            Assert.Equal(6000, Deposit(1000));
        }
    }
}
