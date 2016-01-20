using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecentlyUsedListLibrary;

namespace RecentlyUsedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeExceptionWhenInvalidIndexIsPassed()
        {
            RecentlyUsedList<int> ob = new RecentlyUsedList<int>(5);
            int result = ob[0];
        }

        [TestMethod]
        
        public void ReturnThreeWhenWeRetrievedFirstIndex()
        {
            RecentlyUsedList<int> ob = new RecentlyUsedList<int>(1);
            ob.MyInsert(3);
            Assert.AreEqual(3, ob[0]);
        }

        [TestMethod]

        public void ReturnFiveWhenWeRetrievedFirstIndex()
        {
            RecentlyUsedList<int> ob = new RecentlyUsedList<int>(2);
            ob.MyInsert(3);
            ob.MyInsert(5);
            Assert.AreEqual(5, ob[0]);
            Assert.AreEqual(3, ob[1]);
        }

        [TestMethod]

        public void ReturnSixWhenWeRetrievedFirstIndex()
        {
            RecentlyUsedList<int> ob = new RecentlyUsedList<int>(2);
            ob.MyInsert(6);
            ob.MyInsert(5);
            ob.MyInsert(6);
            Assert.AreEqual(6, ob[0]);
            Assert.AreEqual(5, ob[1]);
        }

        [TestMethod]
       
        public void ReturnThreeWhenFirstIndexIsRetrieved()
        {
            RecentlyUsedList<int> ob = new RecentlyUsedList<int>(2);
            ob.MyInsert(1);
            ob.MyInsert(2);
            ob.MyInsert(3);
            Assert.AreEqual(3, ob[0]);
            Assert.AreEqual(2, ob[1]);
           // Assert.AreEqual(1, ob[2]);
            
        }

        [TestMethod]

        public void ReturnOneWhenWeRetrievedSecondIndex()
        {
            RecentlyUsedList<int> ob = new RecentlyUsedList<int>(2);
            ob.MyInsert(1);
            ob.MyInsert(2);
            ob.MyInsert(1);
            ob.MyInsert(2);

            Assert.AreEqual(2, ob[0]);
            Assert.AreEqual(1, ob[1]);
        }

         [TestMethod]
        public void ReturnGarimaWhenWeRetrievedFirstIndex()
        {
            RecentlyUsedList<string> ob = new RecentlyUsedList<string>(1);
            ob.MyInsert("Garima");

            Assert.AreEqual("Garima", ob[0]);
        }

         [TestMethod]
         public void ReturnBhatiaWhenWeRetrievedFirstIndex()
         {
             RecentlyUsedList<string> ob = new RecentlyUsedList<string>(2);
             ob.MyInsert("Garima");
             ob.MyInsert("Bhatia");

             Assert.AreEqual("Bhatia", ob[0]);
         }

         [TestMethod]
         [ExpectedException(typeof(ArgumentOutOfRangeException))]
         public void ThrowArgumentOutOfRangeExceptionWhenInvalidIndexIsRetrievedWithStrings()
         {
             
             RecentlyUsedList<string> ob = new RecentlyUsedList<string>(2);
             ob.MyInsert("Garima");
             ob.MyInsert("Bhatia");
             string result = ob[2];
         }

         [TestMethod]
        
         public void ReturnABCWhenFirstIndexIsRetrieved()
         {

             RecentlyUsedList<string> ob = new RecentlyUsedList<string>(2);
             ob.MyInsert("Garima");
             ob.MyInsert("Bhatia");
             ob.MyInsert("abc");
             Assert.AreEqual("abc", ob[0]);
         }

         [TestMethod]

         public void ReturnETwoWhenFirstIndexIsRetrieved()
         {

             RecentlyUsedList<Employee> ob = new RecentlyUsedList<Employee>(2);
             Employee e1 = new Employee();
             Employee e2 = new Employee();
             ob.MyInsert(e1);
             ob.MyInsert(e2);
             Assert.AreEqual(e2, ob[0]);
             Assert.AreEqual(e1, ob[1]);
         }

         [TestMethod]
         [ExpectedException(typeof(ArgumentOutOfRangeException))]
         public void ThrowArgumentOutOfRangeExceptionWhenInvalidIndexIsPassedObjects()
         {
             RecentlyUsedList<Employee> ob = new RecentlyUsedList<Employee>(5);
             Employee result = ob[0];
         }

         [TestMethod]
         [ExpectedException(typeof(ArgumentOutOfRangeException))]
         public void ThrowArgumentOutOfRangeExceptionWhenInvalidIndexIsRetrieved()
         {
             RecentlyUsedList<Employee> ob = new RecentlyUsedList<Employee>(2);
             Employee e1 = new Employee();
             Employee e2 = new Employee();
             Employee e3 = new Employee();
             ob.MyInsert(e1);
             ob.MyInsert(e2);
             ob.MyInsert(e3);
             Assert.AreEqual(e3, ob[0]);
             Assert.AreEqual(e2, ob[1]);
             Assert.AreEqual(e1, ob[2]);
             
         }




    }
}
