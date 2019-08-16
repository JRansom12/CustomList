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
            for(int i = 0; i < capacity; i++)
            {
                Array[i] = items[i];
            }
            capacity *= 2;
            items = Array;
        }

        //throw new NotImplementedException();
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
                else //item is found
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
            for(int i = 1; i < count; i++)
                {
                    newString += "," + items[i].ToString();
                }
            return newString;
            //string[] newArray = items.Select(i => i.ToString()).ToArray();
            //return string.Join(",", newArray);
        }
        public void OverloadPlusOperator()
        {

        }

        public int Count //read only
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
            //set
            //{
            //    capacity = value;
            //}
        }
        public T this[int index] //Indexer
        {
            get
            {
                //if (index < 0 && index >= items.Length)
                //    throw new IndexOutOfRangeException("Cannot store more than " + items.Length + " objects");

                return items[index];
            }
            set
            {
                //if (index < 0 && index >= items.Length)
                //    throw new IndexOutOfRangeException("Cannot store more than " + items.Length + " objects");

                items[index] = value;
            }
        }
    }
}
