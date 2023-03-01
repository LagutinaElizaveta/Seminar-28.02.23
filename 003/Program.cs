// Напишите программу, которая преобразовывает десятичное число в двоичное

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите размерность системы счисления, в которую нужно перевести число: ");
int dim = int.Parse(Console.ReadLine());
// Метод перевода числа из десятичной системы в любую другую 
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        res = nums[decNumber % otherSystem] + res;
        decNumber /= otherSystem;
    }
    return res;
}
// Вывод результатов
string res = DecToNum(N, dim);
Console.WriteLine($"{N} -> {res}");