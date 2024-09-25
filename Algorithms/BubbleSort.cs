namespace Algorithms;

public class BubbleSort : ISortAlgorithm
{
    public void Sort(int[] array)
    {
        bool changes = true;

        while (changes)
        {
            changes = false;
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < array[index - 1])
                {
                    int value = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = value;

                    changes = true;
                }
            }
        }
    }
}
