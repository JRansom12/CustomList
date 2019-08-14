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
        private List<T> customList;
        private int count;
        public int capacity;

        // constructor
        public CustomListClass()
        {
            customList = new List<T>();
            items = new T[4];
        }

        // member methods
        public void Add(T itemToAdd)
        {
            //throw new NotImplementedException();
            
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
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
