using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Tests
{
    [TestClass]
    public class RollBackTestClass
    {
        private TransactionScope tScope;

        [TestInitialize]
        public void Initialize()
        {
            tScope = new TransactionScope();
        }

        [TestCleanup]
        public void CleanUp()
        {
            tScope.Dispose();
        }

    }
}
