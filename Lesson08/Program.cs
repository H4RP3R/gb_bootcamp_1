// Рекурсия
// Напишите программу, которая сложит 2 числа a и b без прямого сложения.

int SumNumbers(int x, int y)
{
    if (x == 0) return y;
    else return SumNumbers(x - 1, y + 1);
}

Console.Clear();
Console.Write("Введите 2 числа: ");
int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"Результат {numbers[0]} + {numbers[1]} = {SumNumbers(numbers[0], numbers[1])}");
// S(3, 4) -> S(2, 5) -> S(1, 6) -> S(0, 7) -> 7


// Быстрая сортировка O(n log n)
// [7 ,4 ,1, 3 ,5 ,2, 6] - > [1, 2, 3, 4, 5, 6, 7]
// pivot = 7 (опорный элемент)
// [4, 1, 3, 5, 2, 6] + [7] + [] (элементы меньше опорного, опорный, больше или равны опорному)
// pivot = 4
// [1, 3, 2] + [4] + [5, 6]
// pivot = 1
// [] + [1] + [3, 2]
// pivot = 5
// [] + [5] + [6]
// pivot = 3
// [2] + [3] + []

void InputArray(int[] array)
{
    Random rand = new();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-20, 21);
    }
}

int[] QuickSort(int[] array, int leftIndex, int rightIndex)
{
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while (i <= j)
    {
        while (array[i] < pivot)
        {
            i++;
        }
        while (array[j] > pivot)
        {
            j--;
        }
        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if (leftIndex < j)
    {
        QuickSort(array, leftIndex, j);
    }
    if (i < rightIndex)
    {
        QuickSort(array, i, rightIndex);
    }

    return array;
}

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", QuickSort(array, 0, array.Length - 1))}]");
