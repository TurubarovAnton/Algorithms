namespace Algorithms;

public class PyramidSort : ISortAlgorithm
{
    public void Sort(int[] array)
    {
        for (int position = 0; position < array.Length; position++)
        {
            int min = position;
            for (int index = position; index < array.Length; index++)
                if (array[index] < array[min])
                    min = index;

            int value = array[position];
            array[position] = array[min];
            array[min] = value;
        }
    }
}
