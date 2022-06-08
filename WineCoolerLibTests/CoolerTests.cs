using Microsoft.VisualStudio.TestTools.UnitTesting;
using WineCoolerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCoolerLib.Tests
{
    [TestClass()]
    public class CoolerTests
    {
        private Cooler cooler;

        [TestInitialize]
        public void Initialize()
        {
            cooler = new Cooler(1, 48, 10, 48);
        }

        [TestMethod()]
        public void CoolerIsFull()
        {
            Cooler cooler2 = new Cooler(2, 48, 10, 47);
            Assert.AreEqual(true, cooler.CoolerIsFull());
            Assert.AreEqual(false, cooler2.CoolerIsFull());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoolerIsFullException1()
        {
            Cooler cooler3 = new Cooler(3, 48, 10, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoolerIsFullException2()
        {
            Cooler cooler4 = new Cooler(4, 48, 10, 49);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddWineTest1()
        {
            cooler.AddWine();
        }

        [TestMethod()]
        public void AddWineTest2()
        {
            Cooler cooler5 = new Cooler(5, 48, 10, 2);
            cooler5.AddWine();
            Assert.AreEqual(3, cooler5.AddWine());
        }
    }
}