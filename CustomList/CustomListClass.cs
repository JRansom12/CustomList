using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T> : IEnumerable
    {
        // member variables
        private T[] items;
        public int count { get; private set; }
        public int capacity { get; private set; }

        // constructor
        public CustomListClass()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        // member methods
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                IncreaseCapacity();
            }
            items[count] = itemToAdd;
            count++;
        }
        private void IncreaseCapacity()
        {
            T[] Array = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
            {
                Array[i] = items[i];
            }
            capacity *= 2;
            items = Array;
        }
        public void Remove(T itemToRemove)
        {
            bool itemFound = false;
            for (int i = 0; i <= count; i++)
            {
                if (!itemFound)
                {
                    if (itemToRemove.Equals(items[i]))
                    {
                        itemFound = true;
                        items[i] = items[i + 1];
                        count--;
                    }
                }
                else
                {
                    if (i == count)
                    {
                        items[i] = default;
                    }
                    else
                    {
                        items[i] = items[i + 1];
                    }
                }
            }
        }
        public override string ToString()
        {
            string newString = "";
            newString += items[0].ToString();
            for (int i = 1; i < count; i++)
            {
                newString += /*"," + */items[i].ToString(); //option to add a space, comma, or / inbetween each item
            }
            return newString;
        }
        public static CustomListClass<T> operator + (CustomListClass<T> listOne, CustomListClass<T> listTwo)
        {
            CustomListClass<T> newList = new CustomListClass<T>();
            foreach(T item in listOne)
            {
                newList.Add(item);
            }
            foreach(T item in listTwo)
            {
                newList.Add(item);
            }
            return newList;
        }

        public static CustomListClass<T> operator -(CustomListClass<T> listOne, CustomListClass<T> listTwo)
        {
            CustomListClass<T> newList = new CustomListClass<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (listOne[i].Equals(listTwo[j]))
                    {
                        
                    }

                    //if (listOne[i].Equals(listTwo[j]))
                    //{
                    //    listOne.count--;
                    //    if (i == listOne.count)
                    //    {
                    //        listOne[i] = default;
                    //    }
                    //    else
                    //    {
                    //        listOne[i] = listOne[i + 1];
                    //    }
                    //}
                }
            }
            return newList;
            //foreach(T item in listOne)
            //{
            //    listTwo.Remove(item);
            //}
            //return listOne;
        }

        public static CustomListClass<T> Zip(CustomListClass<T> firstList, CustomListClass<T> secondList)
        {
            CustomListClass<T> newList = new CustomListClass<T>();
            for(int i = 0; i < firstList.count || i < secondList.count; i++)
            {
                if(i < firstList.count)
                {
                    newList.Add(firstList[i]);
                }
                if(i < secondList.count)
                {
                    newList.Add(secondList[i]);
                }
            }
            return newList;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int index] //Indexer
        {
            get
            {
                if (index < 0 && index >= items.Length)
                    throw new IndexOutOfRangeException("Cannot store more than " + items.Length + " objects");
                return items[index];
            }
            set
            {
                if (index < 0 && index >= items.Length)
                    throw new IndexOutOfRangeException("Cannot store more than " + items.Length + " objects");
                items[index] = value;
            }
        }
    }
}
