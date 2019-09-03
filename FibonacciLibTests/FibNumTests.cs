using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib.Tests
{
    [TestClass()]
    public class FibNumTests
    {
        [TestMethod()]
        public void FindTest()
        {
            List<int> expect = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 };
            List<int> result = new List<int>();
            result = FibNum.Find(expect.Count);
            for (int i = 0; i < expect.Count; i++)
            {

                Assert.AreEqual(expect[i],result[i] );
            }
        }
    }
}