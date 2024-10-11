using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;

internal class MergeSort : ISortAlgorithm
{
    public void Sort(int[] array)
    {
        if (array.Length < 2) return;
        if (array.Length == 2)
        {
            if (array[0] > array[1])
            {
                int value = array[0];
                array[0] = array[1];
                array[1] = value;
            }
        }

        int median = array.Length / 2;

        int[] left = new int[median];
        for (int index = 0; index < median; index++)
            left[index] = array[index];


        int[] right = new int[array.Length - median];
        for (int index = 0; index < right.Length; index++)
            right[index] = array[median + index];

        Sort(left);
        Sort(right);

        int[] result = merge(left, right);

        for (int index = 0; index < result.Length; index++)
            array[index] = result[index];
    }

    private int[] merge(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];

        int index = 0;
        int index1 = 0;
        int index2 = 0;

        while (index < result.Length)
        {
            if (index1 == array1.Length)
            {
                result[index] = array2[index2];
                index2++;
            }
            else if (index2 == array2.Length)
            {
                result[index] = array1[index1];
                index1++;
            }
            else if (array1[index1] < array2[index2])
            {
                result[index] = array1[index1];
                index1++;
            }
            else
            {
                result[index] = array2[index2];
                index2++;
            }

            index++;
        }

        return result;
    }
}
