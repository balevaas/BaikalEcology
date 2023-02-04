using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Tests
{
    [TestClass()]
    public class DataManagerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var data = DataManager.Get(DataProvider.Sqlite);
            Assert.IsTrue(true);
        }
    }
}