namespace Calculator666
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vibor;
            double pervoecs, vtoroecs, rezultat;
            do
            {
                Console.WriteLine("Выбирите операцию:");
                Console.WriteLine("1: Сложение");
                Console.WriteLine("2: Вычитание");
                Console.WriteLine("3: Умножение");
                Console.WriteLine("4: Деление");
                Console.WriteLine("5: Возведение в степень");
                Console.WriteLine("6: Извлечение квадратного корня");
                Console.WriteLine("7: Вычилисть 1 процент от числа");
                Console.WriteLine("8: Вычислить факториал числа");
                Console.WriteLine("9: Выйти из программы");
                vibor = int.Parse(Console.ReadLine());
                switch (vibor)
                {
                    case 1:
                        Console.WriteLine("Введите первое число");
                        pervoecs = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        vtoroecs = double.Parse(Console.ReadLine());
                        rezultat = pervoecs + vtoroecs;
                        Console.WriteLine("Резултат:" + rezultat);
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число");
                        pervoecs = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        vtoroecs = double.Parse(Console.ReadLine());
                        rezultat = pervoecs - vtoroecs;
                        Console.WriteLine("Резултат:" + rezultat);
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число");
                        pervoecs = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        vtoroecs = double.Parse(Console.ReadLine());
                        rezultat = pervoecs * vtoroecs;
                        Console.WriteLine("Резултат:" + rezultat);
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число");
                        pervoecs = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        vtoroecs = double.Parse(Console.ReadLine());
                        if (pervoecs == 0)
                            Console.WriteLine("Результат:" + 0);
                        else if (vtoroecs == 0) 
                            Console.WriteLine("На ноль делить нельзя");
                        else
                            Console.WriteLine("Результат:" + pervoecs / vtoroecs);
                        break;
                    case 5:
                        Console.WriteLine("Введите число:");
                        pervoecs = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите степень");
                        int power = int.Parse(Console.ReadLine());
                        rezultat = Math.Pow(pervoecs, power);
                        Console.WriteLine("Результат:" + rezultat);
                        break;
                    case 6:
                        Console.WriteLine("Введите число");
                        pervoecs = double.Parse(Console.ReadLine());
                        rezultat = Math.Sqrt(pervoecs);
                        Console.WriteLine("Резултат:" + rezultat);
                        break;
                    case 7:
                        Console.WriteLine("Введите число");
                        pervoecs = double.Parse(Console.ReadLine());
                        rezultat = pervoecs / 100;
                        Console.WriteLine("Резултат:" + rezultat);
                        break;
                    case 8:
                        Console.WriteLine("Введите число");
                        pervoecs = double.Parse(Console.ReadLine());
                        int faktor = 1;
                            for (int i = 1; pervoecs >= i; i++)
                            {
                                faktor = faktor * i;
                            }
                        Console.WriteLine("Резултат:" + faktor);
                        break;
                    case 9:
                        Console.WriteLine("Программа завершена");
                        break;
                    default:
                        Console.WriteLine("Нет опреации под таким номером");
                        break;
                }
                Console.WriteLine();
            } while (vibor != 9);
            






        }
    }
}