using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayList;

namespace UnitTestAL
{
    [TestClass]
    public class UnitTest1
    {
        arrayList aL = new arrayList();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
           
            //arrange
            int i = 1;

            //act
            int ans= aL.Get(i);
            int expected = 0;

            //assert
            Assert.AreEqual(ans, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {

            //arrange
            int i = 0;
            int val = 6;
            
            //act
            // string ans = aL.Set(i,val);
            //string expected = "6 ";

            //assert
            // Assert.AreEqual(ans, expected);
            Assert.AreEqual("Index out of range. Must be Non-Negative nad less than size of list", aL.Set(-1,10));
            Assert.AreEqual("Index out of range. Must be Non-Negative nad less than size of list", aL.Set(4,10));
        }

        //[TestMethod]
        //public void TestMethod3()
        //{

        //    //arrange
        //    int i = 2;
        //    int val = 5;

        //    //act
        //    string ans = aL.Set(i, val);
        //    string expected = "";

        //    //assert
        //    Assert.AreEqual(ans, expected);
        //}

        //[TestMethod]
        //public void TestMethod4()
        //{

        //    //arrange
        //    int i = 1;
        //    int val = 5;

        //    //act
        //    string ans = aL.Insert(i, val);
        //    string expected = "6 5 ";

        //    //assert
        //    Assert.AreEqual(ans, expected);
        //}

    }
}
