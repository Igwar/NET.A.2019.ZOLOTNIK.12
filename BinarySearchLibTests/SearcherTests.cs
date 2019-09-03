using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchLib.Tests
{
    [TestClass()]
    public class SearcherTests
    {
        [TestMethod()]
        public void BinarySearch_SearchFromArea_InIntArr_WithDelegate_ReturnsIndex1()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(1, Searcher.BinarySearch(arr, 0, 2, 45, delComparison));
        }
        [TestMethod()]
        public void BinarySearch_SearchFromArea_InIntArr_WithIComparer_ReturnsIndex1()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(1, Searcher.BinarySearch(arr, 0, 2, 45, Comparer<int>.Create(delComparison)));
        }
        

    }
}