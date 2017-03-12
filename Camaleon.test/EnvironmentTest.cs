using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Camaleon.test
{
    [TestClass]
    public class EnvironmentTest
    {
        [TestMethod]
        public void ListDatabasesTest()
        {
            var x = lib.Environment.ListTables();
        }
    }
}
