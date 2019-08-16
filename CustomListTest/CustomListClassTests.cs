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
        public void Remove_ItemNotInList_ListStaysTheSame()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 3;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(4);
            actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemFromMiddleOfList_LastIndicieGoesToZero()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int expected = 0;
            int actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(1);
            actual = customList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_IntAddedToList_ConvertToOneString()
        {
            // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            string expected = "1,2,3,4";
            string actual;

            // act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            actual = customList.ToString();


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_StringAddedToList_ConvertToOneString()
        {
            // arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string expected = "One,Two,Three,Four";
            string actual;

            // act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            actual = customList.ToString();


            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
