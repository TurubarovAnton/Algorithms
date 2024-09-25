using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;

public class FastSort : ISortAlgorithm
{
    public void Sort(int[] array)
    {
        if (array.Length == 0) return;

        sort(array, 0, array.Length - 1);
    }

    private void sort(int[] array, int begin, int end)
    {
        if (begin < end)
        {
            int median = begin + (end - begin) / 2;

            int index = begin;
            while (index < median)
            {
                if (array[index] > array[median])
                {
                    replace(array, index, median - 1);
                    replace(array, median - 1, median);

                    median--;
                }
                else index++;
            }

            index = end;
            while (index > median)
            {
                if (array[index] < array[median])
                {
                    replace(array, index, median + 1);
                    replace(array, median + 1, median);

                    median++;
                }
                else index--;
            }

            sort(array, begin, median - 1);
            sort(array, median + 1, end);
        }
    }

    private void replace(int[] array, int index1, int index2)
    {
        int value = array[index1];
        array[index1] = array[index2];
        array[index2] = value;
    }
}
