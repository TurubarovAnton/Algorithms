using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace Algorithms.Tests;

[TestClass]
public class Tester
{
    [TestMethod("Тестирование алгоритма быстрой сортировки")]
    public void TestFastSort()
    {
        TesSort(new FastSort());
    }

    [TestMethod("Тестирование алгоритма пузырьковой сортировки")]
    public void TestBubbleSort()
    {
        TesSort(new BubbleSort());
    }

    [TestMethod("Тестирование алгоритма пирамидальной сортировки")]
    public void TestPyramidSort()
    {
        TesSort(new PyramidSort());
    }

    [TestMethod("Тестирование алгоритма сортировки слиянием")]
    public void TestMergeSort()
    {
        TesSort(new MergeSort());
    }

    private void TesSort(ISortAlgorithm algorithm)
    {
        for (int index = 0; index < 100; index++)
        {
            int[] values = generate();
            int[] expected = values.Order().ToArray();

            Logger.LogMessage("Start sort [" + String.Join(", ", values) + "]");


            algorithm.Sort(values);

            if (Enumerable.SequenceEqual(values, expected))
                Logger.LogMessage("Success sorted [" + String.Join(", ", values) + "]");
            else
                Assert.Fail("Array (" + String.Join(", ", values) + ") is not sorted!");
        }
    }

    private int[] generate()
    {
        int length = Random.Shared.Next(1000, 5000);

        int[] array = new int[length];
        for (int index = 0; index < length; index++)
            array[index] = Random.Shared.Next(-100, 100);

        return array;
    }
}
