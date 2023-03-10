int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("[" + string.Join(", ", array) + "]");

// [4, 5, 3, 1, 2]
// O(n)
// [5, 4, 3, 2, 1] =  O(n*log n)
// ((5 + 1) / 2) * 5 = O(1) выполнили одну единственное действие, чтобы найти сумму чисел.
// Но не всегда алгоритм быстрой сортировки и потом решение в одно действие быстрее O(n).
// n < n * log(n) + 1
// в данном случае лучше решить примером:
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += array[i];
}
// Время для этого примера будет O(n), где n это кол-во элементов в n массиве.
