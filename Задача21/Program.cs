void distance()
{
    Console.Clear();
    Console.Write ("Введите координату X первой точки ");
    double X1  = double.Parse (Console.ReadLine());
    Console.Write ("Введите координату Y первой точки ");
    double Y1  = double.Parse (Console.ReadLine());
    Console.Write ("Введите координату Z первой точки ");
    double Z1  = double.Parse (Console.ReadLine());
    Console.Write ("Введите координату X второй точки ");
    double X2  = double.Parse (Console.ReadLine());
    Console.Write ("Введите координату Y второй точки ");
    double Y2  = double.Parse (Console.ReadLine());
    Console.Write ("Введите координату Z второй точки ");
    double Z2  = double.Parse (Console.ReadLine());
    double D  = 0;

    D = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2)), 2);

    Console.WriteLine($"A ({X1}, {Y1}, {Z1}); B ({X2}, {Y2}, {Z2}) -> {D}");
}
distance();