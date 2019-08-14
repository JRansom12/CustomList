using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T>
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
        public void Remove(T itemToRemove)
        {
            throw new NotImplementedException();
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
