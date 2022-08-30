void distance()
{
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
    double S = 2;
    double X3 = X2 - X1;
    double Y3 = Y2 - Y1;
    double Z3 = Z2 - Z1;

    D = Math.Round(Math.Sqrt(Math.Pow(X3, S) + Math.Pow(Y3, S) + Math.Pow(Z3, S)), 2);

    Console.WriteLine($"A ({X1}, {Y1}, {Z1}); B ({X2}, {Y2}, {Z2}) -> {D}");
}
distance();
