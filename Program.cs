//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void SecondDig(int a)
{
    int asto = a % 100;
    int adva = asto / 10;

    Console.WriteLine($"средняя цифра Вашего числа {adva}");
}

Console.Write("Введите трёхзначное число от 100 до 999: ");
int a = Convert.ToInt32(Console.ReadLine());

SecondDig(a);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Razryad(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
int atri = number % 10;
return atri;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 100) 
{
    int number = Razryad(a);
    Console.WriteLine($"Третья цифра в числе это {number}");
}
else Console.WriteLine("Увы, у этого числа нет третьей цифры.");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void WhereWeekEnd(int number)
{
    if(number > 5) 
    {
        Console.WriteLine ("Выходной! Ура!");
    }
    else Console.WriteLine ("До выходного далеко.");
}

Console.Write("Введите число от 1 до 7, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 7) 
    {
        Console.WriteLine ("Вы ошиблись днём недели, попробуйте ещё!");
    }
    else
        if(number < 1) 
        {
            Console.WriteLine ("Вы ошиблись днём недели, попробуйте ещё!");
        }
        else WhereWeekEnd(number);

*/
