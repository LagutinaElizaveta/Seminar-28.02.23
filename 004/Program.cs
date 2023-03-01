// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования

// Задание параметров массива пользователем
Console.WriteLine("Введите число элементов массива:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива:");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива:");
int maxValue = int.Parse(Console.ReadLine());
// Метод создания массива случайных чисел
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
// Вывод созданного массива
int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ,", array));
// Метод поэлементного копирования массива
int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}
// "Переворачивание" массива
Console.WriteLine(String.Join(" ,", CopyArray(array)));
