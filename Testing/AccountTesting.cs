using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing;

namespace Testing
{
    [TestFixture]
    public class AccountTesting
    {
        Account acc;
        [SetUp]

        public void TestSetup()
        {
            acc = new Account("I-34567");
        }

        [Test]

        public void TestDepositMethod()
        {
            //ask
            acc.Deposit(800);
            //assert
            Assert.AreEqual(1800, acc.CheckBalance());
        }
        public void TestWithdraw()
        {
            //ask
            acc.WithDraw(2000);
        }
        [Test]
        public void TestWithDrawException()
        {
            Assert.Throws<Exception>(TestWithdraw);
        }
        [Test]
        public void JustChecking_Balance()
        {
            Assert.AreNotEqual(1800, acc.CheckBalance());
        }

    }
}
