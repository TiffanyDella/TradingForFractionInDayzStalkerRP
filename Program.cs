using System;

public class PercentageCalculator
{
    public double IncreaseByPercentage(double value, double percentage)
    {
        return value + (value * (percentage / 100));
    }

    public double DecreaseByPercentage(double value, double percentage)
    {
        return value - (value * ((100 - percentage) / 100));
    }

    public void InputAndCalculate(int choose)
    {

        Console.Write("Введите цену товара у НПС: ");
        if (!double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine("Некорректный ввод числа.");
            return;
        }

        Console.Write("Введите процент: ");
        if (!double.TryParse(Console.ReadLine(), out double percentage))
        {
            Console.WriteLine("Некорректный ввод процента.");
            return;
        }

        switch (choose)
        {
            case 1:
                double increasedValue = IncreaseByPercentage(value, percentage);
                Console.WriteLine($"Цена товара: {increasedValue}");
                Console.ReadKey(true);
                break;

            case 2:
                double decreasedValue = DecreaseByPercentage(value, percentage);
                Console.WriteLine($"Сумму которую вы можете забрать себе: {decreasedValue}");
                Console.ReadKey(true);
                break;

            default:
                Console.WriteLine("Некорректный выбор операции.");
                break;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("ПОКУПКА/ПРОДАЖА ДЛЯ ГП\n\nВыберите операцию:");
        Console.WriteLine("1 - Покупка");
        Console.WriteLine("2 - Продажа");

        if (!int.TryParse(Console.ReadLine(), out int choose))
        {
            Console.WriteLine("Некорректный ввод выбора операции.");
            return;
        }

        PercentageCalculator calculator = new PercentageCalculator();
        calculator.InputAndCalculate(choose);
    }
}