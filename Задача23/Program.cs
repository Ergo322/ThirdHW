void KUB()
{
    Console.Clear();
    Console.Write ("Введите число, таблицу кубов которого вы хотите увидеть ");
    double X  = double.Parse (Console.ReadLine());
    double P = 0;
    int count = 1;
    Console.Write($"{X} -> ");
    while (count<=X)
    {
        P = Math.Pow(count,3);
        Console.Write ($"{P},");
        count ++;
    }
} 
KUB();