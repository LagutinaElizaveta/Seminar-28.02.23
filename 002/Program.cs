// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины

// Задание длинн строн пользователем
Console.WriteLine("Введите длину первой стороны:"); // Console.WriteLine("Введите длины сторон через пробел:");
int a = int.Parse(Console.ReadLine());              // string[] st = Console.ReadLine().Split(' ');
Console.WriteLine("Введите длину второй стороны:"); // int a = int.Parse(st[0]);
int b = int.Parse(Console.ReadLine());              // int b = int.Parse(st[1]);
Console.WriteLine("Введите длину третьей стороны:");// int c = int.Parse(st[2]);
int c = int.Parse(Console.ReadLine());
if (a <= 0 || b <= 0 || c <= 0)
{
    Console.WriteLine("Значения длинн сторон должны быть больше 0.");
    return;
}
// Метод проверки соблюдения "теоремы о треугольнике"
bool Triangle(int a, int b, int c)
{
    return (((a + b) > c) && ((b + c) > a) && ((c + a) > b));
}
// Вывод результата
if ((Triangle(a, b, c)))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}