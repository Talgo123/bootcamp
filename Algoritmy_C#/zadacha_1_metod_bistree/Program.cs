// array - 10
// сумма 3 подряд идущих элементов m - 3
//
// 1 5 4 1 3 4 7 4 1 2
// m = 3
// MAX = 15

using System.Diagnostics;

int size = 1_000_000;
int m = 3;
int[] array = Enumerable.Range(1, size).Select(item => Random.Shared.Next(10)).ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");
Stopwatch sw = new();
sw.Start();

int max = 0;
for (int j = 0; j < m; j++) max += array[j];
int t = max;
for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array [i + (m - 1)];
    if (t > max) max = t;
}

sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);
