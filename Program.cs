//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(int num)
{
    int num1 = num;
    int digit1 = num1 / 10000;
    int digit2 = (num1 / 1000) % 10;
    int digit4 = (num1 % 100) / 10;
    int digit5 = num1 % 10;
    if (digit1 == digit5 && digit2 == digit4) Console.Write($"число {num1} палиндром");
    else Console.Write($"число {num1} не палиндром");
}

Console.Write("Введите 5-тизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);
*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double DlinnaOtrezka(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
Console.WriteLine("Введите координаты первой точки: ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());
double xyz = DlinnaOtrezka(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"расстояние между точками равно {xyz}");
*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void CubeN(int num)
{
    int i=1;
    Console.Write("1");
    while(i < num)
    {
        i++;
        Console.Write($", {i*i*i}");
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeN(number);

*/