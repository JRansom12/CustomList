using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomListClass<int> customList;
            customList = new CustomListClass<int>();
            CustomListClass<int> otherList;
            otherList = new CustomListClass<int>();
            //CustomListClass<int> thirdList;
            //otherList = new CustomListClass<int>();

            customList.Add(4);
            customList.Add(0);
            customList.Add(6);
            customList.Add(7);
            customList.Add(-10);
            customList.Remove(6);
            otherList.Add(-10);
            otherList.Add(0);
            otherList.Add(4);

            Console.WriteLine(customList.ToString());
            Console.WriteLine(otherList.ToString());
            foreach(int item in customList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(customList + otherList);
            Console.WriteLine(customList - otherList);
            Console.ReadLine();
        }
    }
}
