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

            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            customList.Remove(6);
            Console.WriteLine(customList.ToString());
            foreach(int item in customList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
