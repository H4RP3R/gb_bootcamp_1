/// <summary>
/// Класс отвечающий за создание массива
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">кол-во элементов</param>
    /// <returns>новый массив</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Создает строку из массива
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Строковое представление массива</returns>
    public static string ConvertToStringAndPrintToTerminal(this int[] array)
    {
        string str = $"[{string.Join(' ', array)}]";
        Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Заполняет массив
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапазона генератора случайных чисел</param>
    /// <param name="max">Верхняя граница диапазона генератора случайных чисел</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = (seed == 0) ? new() : new Random(seed);
        return array.Select(item => random.Next(min, max)).ToArray();
    }
}