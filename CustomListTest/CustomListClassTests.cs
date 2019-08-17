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
        [TestMethod]
        public void ToString_StringAddedToList_WriteLineHasListNotArray()
        {
            // arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string expected = "One,Two,Three,Four,Five";
            string actual;

            // act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            customList.Add("Five");
            actual = customList.ToString();


            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//Have not tested Zip method yet
        public void Zip_TwoListsSame_OneListEachIntTwiceInARow()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { 1, 2, 3 };
            CustomListClass<int> listTwo = new CustomListClass<int>() { 1, 2, 3 };
            CustomListClass<int> expected = new CustomListClass<int>() { 1, 1, 2, 2, 3, 3 };
            CustomListClass<int> actual = new CustomListClass<int>();

            // act
            actual = actual.Zip(listOne, listTwo);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void OverloadPlusOperator_TwoDifferentIntLists_BecomesOneListListOneThenListTwo()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { 1, 3, 5 };
            CustomListClass<int> listTwo = new CustomListClass<int>() { 2, 4, 6 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() { 1, 3, 5, 2, 4, 6 };

            // act
            actual = listOne + listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_ListWithZeroListWithNegatives_BecomesOneListWithAllInt()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { 0, 0, 5 };
            CustomListClass<int> listTwo = new CustomListClass<int>() { -2, -4, 6 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() { 0, 0, 5, -2, -4, 6 };

            // act
            actual = listOne + listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_TwoDifferentDataTypeLists_BecomesOneStringList()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { 1, 2, };
            CustomListClass<string> listTwo = new CustomListClass<string>() { "fish", "fish", };
            CustomListClass<T> actual = new CustomListClass<T>();
            CustomListClass<T> expected = new CustomListClass<T>() { 1, "fish", 2, "fish", };

            // act
            actual = listOne + listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_OneEmptyList_BecomesOneList()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() {};
            CustomListClass<int> listTwo = new CustomListClass<int>() { 2, 4, 6, 8, 10 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() { 2, 4, 6, 8, 10 };

            // act
            actual = listOne + listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_UserStoryExample_DisplaysOneListWithThreeAndFive()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { 1, 3, 5 };
            CustomListClass<int> listTwo = new CustomListClass<int>() { 2, 1, 6 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() { 3, 5 };

            // act
            actual = listOne - listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_FirstListEmpty_EmptyList()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() {};
            CustomListClass<int> listTwo = new CustomListClass<int>() { 2, 1, 6 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() {};

            // act
            actual = listOne - listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_FirstListRepeatedValues_ClearsEachOfRepeatedValues()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { 2, 2, 3, 3, 6, 6 };
            CustomListClass<int> listTwo = new CustomListClass<int>() { 2, 1, 6 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() { 3, 3 };

            // act
            actual = listOne - listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_ListWithZeroListWithNegativeValues_ClearsZeroAndNegativeValues()
        {
            // arrange
            CustomListClass<int> listOne = new CustomListClass<int>() { -2, 2, 3, 0, -6, 6 };
            CustomListClass<int> listTwo = new CustomListClass<int>() { -2, 0, -6 };
            CustomListClass<int> actual = new CustomListClass<int>();
            CustomListClass<int> expected = new CustomListClass<int>() { 2, 3, 6 };

            // act
            actual = listOne - listTwo;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
