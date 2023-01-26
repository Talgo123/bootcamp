// array - 10
// сумма 3 подряд идущих элементов m - 3
//
// 1 5 4 1 3 4 7 4 1 2
// m = 3
// MAX = 15

using System.Diagnostics;

int size = 1_000_000;
int m = 30000;
int[] array = Enumerable.Range(1, size).Select(item => Random.Shared.Next(10)).ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");
Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++)
    {
        t = t + array[j];
    }
    if (t > max)
        max = t;
}

sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);
