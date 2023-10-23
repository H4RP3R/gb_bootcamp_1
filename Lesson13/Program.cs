// Сортировка подсчетом
// [0, 2, 3, 2, 1, 5, 9, 1, 1]
// [0, 0, 0, 0, 0, 0, 0, 0, 0, 0] создается новый пустой массив в 10 элементов
// Каждой позиции в новом массиве соответствует количество повторений числа (номера позиции) в исходном массиве
//          [1, 3, 2, 1, 0, 1, 0, 0, 0, 1]
// позиции   0  1  2  3  4  5  6  7  8  9
// Расставляем числа соответствующее число раз в массив. Получаем отсортированный массив
// => [0, 1, 1, 1, 2, 2, 3, 5, 9]

int[] array1 = { 0, 2, 3, 2, 1, 5, 9, 1, 1 };
int[] array2 = { 9, 20, 6, -5, 16, 0, 1, 6, 0, -34, 32, 10, 8, 6, 1 };

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10];

    for (int i = 0; i < inputArray.Length; i++)
    {
        // int ourNumber = inputArray[i];
        // counters[ourNumber]++;
        counters[inputArray[i]]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];


    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

Console.WriteLine($"[{string.Join(", ", array1)}]");
CountingSort(array1);
Console.WriteLine($"[{string.Join(", ", array1)}]");
Console.WriteLine();

Console.WriteLine($"[{string.Join(", ", array2)}]");
CountingSortExtended(array2);
Console.WriteLine($"[{string.Join(", ", array2)}]");
