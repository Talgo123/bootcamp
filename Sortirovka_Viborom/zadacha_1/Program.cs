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


using static Sorting;
using static Infrastructure;

// int[] array = CreateArray(10);
// Print(array);
// SortSelection(array);
// Print(array);

10.CreateArray(min: 10, max: 20).Print(",").SortSelection().Print("|");

double res = 2.Pow(10);
System.Console.WriteLine(res);