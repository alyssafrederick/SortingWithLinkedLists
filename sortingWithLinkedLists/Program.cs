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
            //numlist.Add(6);
            //numlist.Add(2);
            //numlist.Add(7);
            //numlist.Add(3);
            //numlist.Add(5);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                numlist.Add(rnd.Next(1, 11));
            }

            for (int j = 0; j < numlist.Size; j++)
            {
                Console.WriteLine("{0}", numlist[j]);
            }

            // 6, 2, 7, 3, 5
            // 2, 3, 5, 6, 7


            ////////////////////////////////////bubble sort////////////////////
            //bool switched;

            //do
            //{
            //    switched = false;

            //    for (int i = 0; i < numlist.Size; i++)
            //    {

            //        if (numlist[i] > numlist[i + 1])
            //        {
            //            int temp = numlist[i];
            //            numlist[i] = numlist[i + 1];
            //            numlist[i + 1] = temp;

            //            switched = true;
            //        }
            //    }

            //} while (switched == true);

            //Console.Write("\n \n");

            //for (int j = 0; j < numlist.Size; j++)
            //{
            //    Console.WriteLine("{0}", numlist[j]);
            //}





            /////////////////////////////////////selection sort//////////////////
            //int index2swap;
            //int whereWeAre;

            //for (int i = 0; i < numlist.Size; i++)
            //{
            //    index2swap = i;
            //    whereWeAre = numlist[i];

            //    for (int k = i + 1; k < numlist.Size; k++)
            //    {
            //        if (whereWeAre > numlist[k])
            //        {
            //            index2swap = k;
            //            whereWeAre = numlist[k];
            //        }
            //    }

            //    int temp = numlist[i];
            //    numlist[i] = numlist[index2swap];
            //    numlist[index2swap] = temp;
            //}

            //Console.Write("\n \n");

            //for (int j = 0; j < numlist.Size; j++)
            //{
            //    Console.WriteLine("{0}", numlist[j]);
            //}





            ////////////////////////////////////////////insertion sort////////////
            for (int i = 0; i < numlist.Size; i++)
            {
                for (int a = i - 1; a > -1; a--)
                {
                    if (numlist[a] > numlist[a + 1])
                    {
                        int temp = numlist[a + 1];
                        numlist[a + 1] = numlist[a];
                        numlist[a] = temp;
                    }
                }
            }



            Console.Write("\n \n");

            for (int j = 0; j < numlist.Size; j++)
            {
                Console.WriteLine("{0}", numlist[j]);
            }


            Console.ReadKey();
        }
    }
}
