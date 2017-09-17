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
            numlist.Add(6);
            numlist.Add(2);
            numlist.Add(7);
            numlist.Add(3);
            numlist.Add(5);

            // 6, 2, 7, 3, 5

            // 2, 6, 7, 3, 5
            // 2, 6, 3, 7, 5
            // 2, 6, 3, 5, 7
            // 2, 3, 6, 5, 7
            // 2, 3, 5, 6, 7


            ////////////////////////////////////bubble sort
            bool switched;

            do
            {
                switched = false;

                for (int i = 0; i < numlist.Size; i++)
                {

                    if (numlist[i] > numlist[i + 1])
                    {
                        int temp = numlist[i];
                        numlist[i] = numlist[i + 1];
                        numlist[i + 1] = temp;

                        switched = true;
                    }
                }

            } while (switched == true);

            Console.Write("\n \n");

            for (int j = 0; j < numlist.Size + 1; j++)
            {
                Console.WriteLine("{0}", numlist[j]);
            }

            Console.ReadKey();


            ///////////////////////////////////insertion sort 

        }
    }
}
