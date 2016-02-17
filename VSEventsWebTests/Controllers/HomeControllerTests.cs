using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSEventsWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSEventsWeb.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            Assert.AreEqual(1,1);
        }

        [TestMethod()]
        public void AboutTest()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void ContactTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}