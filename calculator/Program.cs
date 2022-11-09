Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
int operation = 0;
do
{
    operation = Convert.ToInt32(Console.ReadLine());
    double i = 1;
    if (operation == 1)
    {
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        i = number1 + number2;
    }
    else if (operation == 2)
    {
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        i = number1 - number2;
    }
    else if (operation == 3)
    {
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        i = number1 * number2;
    }
    else if (operation == 4)
    {
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        i = number1 / number2;
    }
    else if (operation == 5)
    {
        Console.WriteLine("Введите число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите степень, в которое нужно возвести число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        i = Math.Pow(number1, number2);
    }
    else if (operation == 6)
    {
        Console.WriteLine("Введите число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        i = Math.Sqrt(number1); 
    }
    else if (operation == 7)
    {
        Console.WriteLine("Введите число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        i = number1 / 100;
    }
    else if (operation == 8)
    {
        Console.WriteLine("Введите число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        for (int j = 1; j <= number1; j++)
            i *= j;
    }
    else if (operation < 1 || operation > 9)
    {
        Console.WriteLine("Ошибка, введите существующую операцию");
    }
    Console.WriteLine("Результат: " + i);
    Console.WriteLine("\nВведите операцию еще раз");
} 
while (operation != 9);
