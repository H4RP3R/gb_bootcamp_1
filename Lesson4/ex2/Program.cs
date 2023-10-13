// Сортировка выбором
// На каждом i-ом шаге алгоритма находим минимальный элемент и меняем его местами с i-ым элементом в массиве.

// a1 a2 a3 a4 ... an   n-1 действия
//    a2 a3 a4 ... an   n-2
//       a3 a4 ... an   n-3
//            .....     n-4
//                      n-5
//                      ...
//                       3
//                       2 действия
//                       1 действие
//      
// 1 + 2 + 3 + ... + (n-3) + (n-2) + (n-1) => n * n/2 => n^2/2 => O(n^2)
//
// 1 + n - 2 -> n
// 2 + n - 2 -> n
// ...
// 
// 1    9   n/2
// 2    8
// 3    7
// 4    6
// 5    5 

// Сложность O(n^2)      

// 7 6 3 4 5 1 2 3 <| 0
// 1 6 3 4 5 7 2 3 <| 1
// 1 2 3 4 5 7 6 3 <| 2
// 1 2 3 4 5 7 6 3 <| 3
// 1 2 3 3 5 7 6 4 <| 4
// 1 2 3 3 4 7 6 5 <| 5
// 1 2 3 3 4 5 6 7 <| 6
// 1 2 3 3 4 5 6 7 <| 7
// 1 2 3 3 4 5 6 7 <| 8

int[] SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}


int[] array = new int[] { 7, 6, 3, 4, 5, 1, 2, 3 };
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", SortSelection(array)));
