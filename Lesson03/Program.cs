int n = 5;
int[] array = new int[5];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(array[3]);
// Сложность алгоритма O(1)

// [4, 5, 3, 2, 1]
// O(n)
// [1, 2, 3, 4, 5] - O(n * log  n) быстрая сортировка  
// ((5 + 1)/2) * 5 - O(1)
// Сумма n членов арифметической прогрессии равна произведению полусуммы ее крайних членов на число членов прогрессии.
// https://dl.bsu.by/mod/book/view.php?id=10178&chapterid=1275

// При использовании каких либо сложных алгоритмов можно получить большую затрату времени на выполнение какой либо
// программы n < n * log(n) + 1
int summ = 0;
for (int i = 0; i < n; i++)
{
    summ += array[i];
}
Console.WriteLine(summ);


int num = Convert.ToInt32(Console.ReadLine());
string div = string.Empty;
Console.Write("    ");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{i,3}");
    div += "___";
}
Console.WriteLine("\n    " + div);

// O(n^2)
for (int i = 1; i <= num; i++)
{
    Console.Write($"{i,3}|");
    for (int j = 1; j <= num; j++)
    {
        Console.Write($"{i * j,3}");
    }
    Console.WriteLine();
}

//       1  2  3  4  5  6  7  8  9
//     ___________________________
//   1|  1  2  3  4  5  6  7  8  9
//   2|  2  4  6  8 10 12 14 16 18
//   3|  3  6  9 12 15 18 21 24 27
//   4|  4  8 12 16 20 24 28 32 36
//   5|  5 10 15 20 25 30 35 40 45
//   6|  6 12 18 24 30 36 42 48 54
//   7|  7 14 21 28 35 42 49 56 63
//   8|  8 16 24 32 40 48 56 64 72
//   9|  9 18 27 36 45 54 63 72 81

Console.WriteLine();
int[,] matrix = new int[num, num];
for (int i = 0; i < num; i++)
{
    for (int j = i; j < num; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}

// O(n^2 / 2)
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j],3}");
    }
    Console.WriteLine();
}

// Пять столпов асимптотической оценки сложности простых алгоритмов
// https://t.me/iksergeyru/121
