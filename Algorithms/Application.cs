using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;

internal class Application
{
    private static Application instance;
    private static Object locker = new Object();

    public static Application Instance { get
        {
            if (instance == null)
                lock (locker) {  
                    if (instance == null)
                        instance = new Application();
                }

            return instance;
        }
    }

    public async Task Run()
    {
        int[] array = { -58, -78, -59, -75, -62, 26, -74, -53, 28, -20, -13, -8, 62, 66, 68, 55 };

        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        await Task.Run(() =>
        {
            PyramidSort instance = new();
            instance.Sort(array);

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        });

        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        Console.WriteLine(String.Join(", ", array));
    }
}
