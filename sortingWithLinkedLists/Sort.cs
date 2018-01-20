using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingWithLinkedLists
{
    class Sort<T> where T : IComparable
    {
        public void BubbleSort(LinkedList<T> tosort)
        {
            bool switched;

            do
            {
                switched = false;

                for (int i = 0; i < tosort.Size - 1; i++)
                {

                    if (tosort[i].CompareTo(tosort[i + 1]) > 0)
                    {
                        T temp = tosort[i];
                        tosort[i] = tosort[i + 1];
                        tosort[i + 1] = temp;

                        switched = true;
                    }
                }

            } while (switched == true);

            Console.Write("\n \n");

            for (int k = 0; k < tosort.Size; k++)
            {
                Console.WriteLine("{0}", tosort[k]);
            }
        }

        public void SelectionSort(LinkedList<T> tosort)
        {
            int index2swap;
            T whereWeAre;

            for (int i = 0; i < tosort.Size; i++)
            {
                index2swap = i;
                whereWeAre = tosort[i];

                for (int k = i + 1; k < tosort.Size; k++)
                {
                    if (whereWeAre.CompareTo(tosort[k]) > 0)
                    {
                        index2swap = k;
                        whereWeAre = tosort[k];
                    }
                }

                T temp = tosort[i];
                tosort[i] = tosort[index2swap];
                tosort[index2swap] = temp;
            }

            Console.Write("\n \n");

            for (int j = 0; j < tosort.Size; j++)
            {
                Console.WriteLine("{0}", tosort[j]);
            }
        }

        public void InsertionSort(LinkedList<T> tosort)
        {
            for (int i = 0; i < tosort.Size; i++)
            {
                for (int a = i - 1; a > -1; a--)
                {
                    if (tosort[a].CompareTo(tosort[a + 1]) > 0)
                    {
                        T temp = tosort[a + 1];
                        tosort[a + 1] = tosort[a];
                        tosort[a] = temp;
                    }
                }
            }

            Console.Write("\n \n");

            for (int j = 0; j < tosort.Size; j++)
            {
                Console.WriteLine("{0}", tosort[j]);
            }
        }

        public void mergesort(LinkedList<T> tosort, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                mergesort(tosort, start, middle);
                mergesort(tosort, middle + 1, end);

                merge(tosort, start, end);
            }
        }

        public void merge(LinkedList<T> tosort, int start, int end)
        {           
            if (tosort[start].CompareTo(tosort[end]) > 0)
            {
                T temp = tosort[start];
                tosort[start] = tosort[end];
                tosort[end] = temp;
            }

        }

        public void MergeSort(LinkedList<T> tosort)
        {
            mergesort(tosort, 0, tosort.Size - 1);

            Console.Write("\n \n");

            for (int j = 0; j < tosort.Size; j++)
            {
                Console.WriteLine("{0}", tosort[j]);
            }
        }

    }
}
