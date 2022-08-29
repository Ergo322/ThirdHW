// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
void Polindrom()
{
    Console.Write ("Введите пятизначное целое число ");
    int N  = Convert.ToInt32 (Console.ReadLine());
    int Num1 = N /10000;
    int Num2 = N / 1000 % 10;
    int Num4 = N % 100 / 10;
    int Num5 = N % 10;


    if (Num1==Num5 && Num2==Num4)
    {
        Console.WriteLine($"{N} -> являеться палидромом");
    }
    else 
    Console.WriteLine ($"{N} -> не являеться палидромом");
}
Polindrom();