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
        private readonly T[] items;
        public int count { get; private set; }
        public int capacity { get; private set; }

        // constructor
        public CustomListClass()
        {
            items = new T[4];
            count = 0;
            capacity = 10;
        }

        // member methods
        //throw new NotImplementedException();
        public void Add(T itemToAdd) //imitate the c# Add method
        {
            items[count] = itemToAdd;
            count++;
            if (count >= capacity)
            {
                capacity *= 2;
            }
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
