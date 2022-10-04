// Zadacha19();
//Zadacha21();
//Zadacha23();


void Zadacha19()
{
    Console.WriteLine("Задача 19 ");
    Console.Write("Введи пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int number_2 = number;
    int resultat = 0;
    if (number > 9999 && number < 100000)
    {
        while (number_2 > 0)
        {
            int n = number_2 % 10;
            resultat = resultat * 10 + n;
            number_2 /= 10;

            Console.WriteLine(resultat);
        }
        if (number == resultat)
        {
            Console.WriteLine($"чило{number} палиндром");
        }
        else
        {
            Console.WriteLine($"чило{number} не палиндром");
        }
    }
    else
    {
        Console.WriteLine("не пятизначное число");
    }
}

void Zadacha21()
{
   Console.WriteLine("Задача 21 ");
    Console.WriteLine("Введите координату для А по плоскости Х:");
    int x_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату для А по плоскости У:");
    int y_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату для А по плоскости z:");
    int z_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату для В по плоскости Х:");
    int x_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату для В по плоскости У:");
    int y_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату для В по плоскости z:");
    int z_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A({x_first},{y_first},{z_first})");
    Console.WriteLine($"B({x_second},{y_second},{z_second})");

    int k = x_second - x_first;
    int m = y_second - y_first;
    int l = z_second - z_first;

    double distance = Math.Sqrt(k * k + m * m + l * l);
    distance = Math.Round(distance, 2); 
    Console.WriteLine($"Длинна {distance}");
}

void Zadacha23()
{
     Console.WriteLine("Задача 23 ");
     Console.WriteLine("Введите число:");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double Cube;
    while (i <= n)
    {
        Cube = Math.Pow(i, 3);
        Console.WriteLine($"|{i}|{Cube}|");
        i++;
    }
}