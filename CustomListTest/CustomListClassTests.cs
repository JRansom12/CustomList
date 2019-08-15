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
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 2;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        // UnitOfWork--Method_StateUnderTest_ExpectedResult
        // write a test for when the array size changes (what is you array's starting size?)
        public void Add_AddToListAtMaxCapacity_ArraySizeDoubles()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 5;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToListAtMaxCapacity_ArraySizeDoublesToSixteen()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 9;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            customList.Add(9);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            customList.Add(1);
            actual = customList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 2;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            actual = customList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            customList.Add(198765);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }




        [TestMethod]
        public void Remove_OneItemFromList_CountGoesDownToOne()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 1;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Remove(1);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FirstInstanceOfItemFromList_CountGoesDownToTwo()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 2;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(2);
            customList.Remove(2);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemFromList_ArraySizeStaysSame()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 8;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(2);
            customList.Add(1);
            customList.Add(2);
            customList.Remove(2);
            actual = customList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemFromMiddleOfList_ListShrinksByOne()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 4;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Remove(3);
            actual = customList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
