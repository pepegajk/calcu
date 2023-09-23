using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в кофемашину!");
        Console.WriteLine("Выберите напиток:");
        Console.WriteLine("1. Эспрессо - 70р");
        Console.WriteLine("2. Латте - 100р");
        Console.WriteLine("3. Капучино - 130р");

        double choice = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                MakeCoffee("Эспрессо", 70);
                break;
            case 2:
                MakeCoffee("Латте", 100);
                break;
            case 3:
                MakeCoffee("Капучино", 130);
                break;
            default:
                Console.WriteLine("Неверный выбор!");
                break;
        }
    
    }
    static void MakeCoffee(string coffeeType, double price)
    {

        Console.WriteLine($"Ваш {coffeeType} готов!");

        Console.WriteLine($"Цена: {price}$");

        Console.WriteLine("Введите сумму:");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount < price)
        {
            Console.WriteLine("Недостаточно средств!");
            return;
        }

        double change = amount - price;
        Console.WriteLine($"Ваша сдача: {change}$");
    }
}