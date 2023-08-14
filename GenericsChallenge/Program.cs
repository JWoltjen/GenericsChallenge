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

        private static List<T> IntermixLists<T>(List<T> list1, List<T> list2)
        {
            List<T> output = new List<T>();
            List<T> biggerList;
            List<T> smallerList;

            if (list1.Count > list2.Count)
            {
                biggerList = list1;
                smallerList = list2;
            }
            else
            {
                biggerList = list2;
                smallerList = list1;
            }

            int smallerCount = smallerList.Count;


            // iterate through the biggerlist as that is the range
            for (int i = 0; i < biggerList.Count; i++)
            {
                // add biggerList at i
                output.Add(biggerList[i]);

                // if the index is less than the count of the smaller list, add 
                // the smallerList at i as well
                // this way it will go, biggerList, smallerList, biggerList, smallerList
                // until smallerList runs out.
                // This is how we merge the lists together.
                if (i < smallerCount)
                {
                    output.Add(smallerList[i]);
                }
            }
            return output;
        }

        // Create another generics method that takes in two
        // generic objects(of the same or different types). Make
        // sure each object that is passed in has a Title property
        // in it.Return the object with the longer title.

        private static void DetermineLongerTitle<T, U>(T item1, U item2)
        {

        }

    }
}
