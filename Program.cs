// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Первое число {a} больше второго {b}");
}
else
    if(a < b)
        {
            Console.WriteLine($"Первое число {a} меньше второго {b}");
        }
    else Console.WriteLine($"Первое число {a} равно второму {b}");

*/

/*Я не знаю что делать с этими примерчиками в ДЗ:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
это обязательно выводить в таком виде или просто для тренировки\тестировании задачи?
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max)
{
    max = number2;
    if(number3 > max)
    {
    max = number3;
    }
}
Console.WriteLine($"максимальным числом является {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} четное.");
}
else Console.WriteLine($"Число {number} нечетное.");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N<=1)
{
    Console.WriteLine($"От 1 до {N} нет натуральных четных чисел.");
}
else Console.Write($"Четные числа от 1 до {N}: ");

while (N>1)
{
    if (N % 2 == 0)
    {
        Console.Write(N + " ");
        N = N - 1;
    }
    N = N - 1;
}
*/