// 7 2 3 4 5 1 2 3

// Сортируем от MIN к MAX
// v
// 0 1 2 3 4 5 6 7 
// 7 6 3 4 5 1 2 3  То что было
//           ^
// 1 6 3 4 5 7 2 3  ТО что стало
//   v
// 1 6 3 4 5 7 2 3 Следующая итерация  То что было
//             ^
//
// 1 2 3 4 5 7 6 3  То что стало
//     v
// 0 1 2 3 4 5 6 7  
// 1 2 3 4 5 7 6 3  В этой итерации элемент меняется сам с собой
//     v
        // v
// 0 1 2 3 4 5 6 7  следующая итерация
// 1 2 3 4 5 7 6 3  то что было
//               ^
// 1 2 3 3 5 7 6 4 то что стало 



void SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos])
            {
                pos = j;
            }
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
}

int[] array = {7, 6, 3, 4, 5, 1, 2, 3};
System.Console.WriteLine($"[{string.Join(",", array)}]");
SortSelection(array);
System.Console.WriteLine($"[{string.Join(",", array)}]");