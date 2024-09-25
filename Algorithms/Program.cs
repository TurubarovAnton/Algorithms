
using Algorithms;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

int[] array = { -58, -78, -59, -75, -62, 26, -74, -53, 28, -20, -13, -8, 62, 66, 68 };

Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

await Task.Run(() =>
{
    PyramidSort instance = new();
    instance.Sort(array);

    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
});

Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

Console.WriteLine(String.Join(", ", array));
