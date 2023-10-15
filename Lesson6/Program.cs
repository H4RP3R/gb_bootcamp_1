// Пузырьковая сортировка

// Сложность алгоритма
// (n-1) * (n-1) = (n-1)^2 = n^2 -2n + 1 => O(n^2)

using System.Diagnostics;

bool Check(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }

    return true;
}

int n = 100_000;
int max = 100;
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Random.Shared.Next(max);
}

int[] arr1 = new int[n];
int[] arr2 = new int[n];

Array.Copy(array, arr1, n);
Array.Copy(array, arr2, n);

// Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"sorted: {Check(array)}");

void BubbleSort1(int[] array)
{
    for (int k = 0; k < n; k++)
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

void BubbleSort2(int[] array) // optimized
{
    for (int k = 0; k < n; k++)
    {
        for (int i = 0; i < n - 1 - k; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

Stopwatch sw = new();

sw.Start();
BubbleSort1(arr1);
sw.Stop();
Console.WriteLine($"arr1 sorted: {Check(arr1)} elapsed: {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
BubbleSort2(arr2);
sw.Stop();
Console.WriteLine($"arr2 sorted: {Check(arr2)} elapsed: {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
Array.Sort(array);
sw.Stop();
Console.WriteLine($"array sorted: {Check(array)} elapsed: {sw.ElapsedMilliseconds}");
