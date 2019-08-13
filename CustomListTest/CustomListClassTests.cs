using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListClassTests
    {
        [TestMethod]
        public void Add_AddToListWithExistingItem_CounterGoesUpOne()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        // UnitOfWork--Method_StateUnderTest_ExpectedResult
        // write a test for when the array size changes (what is you array's starting size?)
        public void Add_AddToListAtMaxCapacity_ArraySizeDoubles()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 5;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToListAtMaxCapacity_ArraySizeDoublesToSixteen()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 9;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            // arrange
            CustomListClass<int> testList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(198765);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
