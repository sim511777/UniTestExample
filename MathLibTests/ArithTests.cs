using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.Tests
{
    [TestClass()]
    public class ArithTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(7, MathLib.Arith.Add(3, 4));
        }

        [TestMethod()]
        public void SubTest()
        {
            Assert.AreEqual(-1, MathLib.Arith.Sub(3, 4));
        }

        [TestMethod()]
        public void MulTest()
        {
            Assert.AreEqual(12, MathLib.Arith.Mul(3, 4));
        }

        [TestMethod()]
        public void DivTest()
        {
            Assert.AreEqual(0, MathLib.Arith.Div(3, 4));
        }
    }
}