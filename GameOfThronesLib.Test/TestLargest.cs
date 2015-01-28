using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfThronesLib;
using System.Web.Http;

namespace GameOfThronesLib.Test
{
    [TestClass]
    public class TestLargest
    {
        private Controller.FamiliyController _familyController = new Controller.FamiliyController();

        [TestMethod]
        public void LargestOf3()
        {
            Assert.AreEqual(9, _familyController.Largest(new int[] { 9, 8, 7 }));
            Assert.AreEqual(9, _familyController.Largest(new int[] { 8, 9, 7 }));
            Assert.AreEqual(9, _familyController.Largest(new int[] { 7, 8, 9 }));
        }

        [TestMethod]
        public void TestDups()
        {
            Assert.AreEqual(9, _familyController.Largest(new int[] { 9, 7, 9, 8 }));
        }

        [TestMethod]
        public void TestOne()
        {
            Assert.AreEqual(1, _familyController.Largest(new int[] { 1 }));
        }

        [TestMethod]
        public void TestNegative()
        {
            int[] negList = new int[] { -9, -8, -7 };
            Assert.AreEqual(-7, _familyController.Largest(negList));
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestEmpty()
        {
            _familyController.Largest(new int[] { });
        }
    }
}