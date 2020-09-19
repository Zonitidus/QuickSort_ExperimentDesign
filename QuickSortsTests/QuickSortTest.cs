using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort_ExperimentDesign_Randomized_NotRandomized_;
using QuickSort_ExperimentDesign_Randomized_NotRandomized_.SortingAlgorithms;
using System.Collections.Generic;

namespace QuickSortsTests
{
    [TestClass]
    public class QuickSortTest
    {
        //private QuickSort<string> quick;
        private QuickSort<Int32> SmallInt32Scene (){
            QuickSort<Int32> quick = new QuickSort<Int32>();
            return quick;
        }
        [TestMethod]
        public void TestSortingInInt32()
        {
            Int32[] tsOrder = {0,2,4,6,9,86};
            Int32[] ts = {4,6,86,9,0,2};
            SmallInt32Scene().QuickSortAlgorithm(ts,0,5);
            string resul1 = string.Join(".", tsOrder);
            string resul2 = string.Join(".", ts);
            Console.WriteLine(ts);
            Assert.AreEqual(resul1,resul2);
        }
    }
}
