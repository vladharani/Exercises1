using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AthleteExercises
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int N = 36;          
            int NumberOfRepetitions = N*N;
            Assert.AreEqual(1296, NumberOfRepetitions);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int N = 36;
            int NumberOfRepetitions = N * N;
            Assert.AreEqual(14000, NumberOfRepetitions);
        }
    }
}