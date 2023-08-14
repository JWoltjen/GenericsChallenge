using System;
using System.Collections.Generic;

namespace GenericsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage with integers
            List<string> list1 = new List<string> { "Count One", "Count Two", "Count Three", "Count Four", "Count Five" };
            List<string> list2 = new List<string> { "Count 1", "Count 2", "Count 3" };

            List<string> intermixedList = IntermixLists(list1, list2);

            Console.WriteLine("Intermixed List:");
            foreach (string item in intermixedList)
            {
                Console.WriteLine(item);
            }
        }

        static List<T> IntermixLists<T>(List<T> list1, List<T> list2)
        {
            List<T> resultList = new List<T>();
            int index1 = 0, index2 = 0;

            // Determine which list is bigger to start with that one
            bool pullFromList1 = list1.Count >= list2.Count;

            while (index1 < list1.Count || index2 < list2.Count)
            {
                if (pullFromList1 && index1 < list1.Count)
                {
                    resultList.Add(list1[index1++]);
                }
                else if (index2 < list2.Count)
                {
                    resultList.Add(list2[index2++]);
                }

                // Alternate between lists
                pullFromList1 = !pullFromList1;
            }

            return resultList;
        }
    }
}
