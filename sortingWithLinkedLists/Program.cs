using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingWithLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numlist = new LinkedList<int>();

            Random rnd = new Random(1);
            for (int i = 0; i < 10; i++)
            {
                numlist.Add(rnd.Next(1, 11));
            }

            for (int j = 0; j < numlist.Size; j++)
            {
                Console.Write("{0}, ", numlist[j]);
            }




            Sort<int> sortthis = new Sort<int>();

            //sortthis.BubbleSort(numlist);
            //sortthis.SelectionSort(numlist);
            //sortthis.InsertionSort(numlist);
            //sortthis.MergeSort(numlist);
            sortthis.QuickSort(numlist);

            Console.ReadKey();
        }
    }
}
