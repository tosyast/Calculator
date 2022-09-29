Console.WriteLine("Калькулятор");
Console.WriteLine("1.Сложить два числа");
Console.WriteLine("2.Вычесть первое из второго");
Console.WriteLine("3.Перемножить два числа");
Console.WriteLine("4.Разделить первое на второе");
Console.WriteLine("5.Возвести в степень N первое число");
Console.WriteLine("6.Найти квадратный корень из числа");
Console.WriteLine("7.Найти 1 процент от числа");
Console.WriteLine("8.Найти факториал числа");
Console.WriteLine("9.Выйти из программы");



string chislo;

do
{
    Console.WriteLine("Введите номер операции:");
    chislo = Console.ReadLine();
    if (chislo == "9")
    {
        Console.WriteLine("Программа завершена.");
        Environment.Exit(0);

    }
    if (chislo == "0")
    {
        Console.WriteLine("Ошибка, введите число от 1 до 9");

    }


    if (chislo == "1")
    {
        Console.WriteLine("1.Сложить два числа");
        Console.WriteLine("Введите первое число");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double chislo2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(chislo1 + chislo2);

    }

    if (chislo == "2")
    {
        Console.WriteLine("2.Вычесть первое из второго");
        Console.WriteLine("Введите первое число");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double chislo2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(chislo1 - chislo2);

    }
    if (chislo == "3")
    {
        Console.WriteLine("3.Перемножить два числа");
        Console.WriteLine("Введите первое число");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double chislo2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(chislo1 * chislo2);

    }
    if (chislo == "4")
    {
        Console.WriteLine("4.Разделить первое на второе");
        Console.WriteLine("Введите первое число");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double chislo2 = Convert.ToDouble(Console.ReadLine());
        if (chislo2 == 0)
        {
            Console.WriteLine("На 0 делить нельзя! Введи другое число.");
        }

        double answer = (chislo1 / chislo2);
        Console.WriteLine(answer);

    }
    if (chislo == "5")
    {
        Console.WriteLine("5.Возвести в степень N первое число");
        Console.WriteLine("Введите первое число");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите, в какую степень вы хотите возвести первое число");
        double stepen = Convert.ToDouble(Console.ReadLine());
        double answer = Convert.ToDouble(Math.Pow(chislo1, stepen));
        Console.WriteLine(answer);

    }
    if (chislo == "6")
    {
        Console.WriteLine("6.Найти квадратный корень из числа");
        Console.WriteLine("Введите число, квадратный корень которого нужно найти");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        double answer = Convert.ToDouble(Math.Sqrt(chislo1));
        Console.WriteLine(answer);

    }
    if (chislo == "7")
    {
        Console.WriteLine("7.Найти 1 процент от числа");
        Console.WriteLine("Введите число, от которого нужно найти 1 %");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        double answer = Convert.ToDouble(chislo1 / 100);
        Console.WriteLine(answer);
    }
    if (chislo == "8")
    {
        Console.WriteLine("8.Найти факториал числа");
        Console.WriteLine("Введите число, от которого нужно найти факториал");
        int chislo1 = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= chislo1; i++)
        {
            factorial *= i;
            if (i == chislo1)
            {
                Console.WriteLine(factorial);
            }
        }

    }

} while (chislo != "9");
