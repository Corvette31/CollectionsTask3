using System;
using System.Collections.Generic;

namespace CollectionsTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string userInput = "";
            bool isRun = true;

            Console.WriteLine("Вводите числа. sum - текущая сумма введенных чисел. exit - выход из программы");

            while (isRun)
            {
                Console.Write("Введите число или команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "sum":
                        ShowSum(numbers);
                        break;
                    case "exit":
                        isRun = false;
                        break;
                    default:
                        AddNumber(userInput, numbers);
                        break;
                }
            }
        }

        static void AddNumber(string userInput, List<int> numbers)
        {
            int number;

            if (int.TryParse(userInput, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Введено не корректное значение");
            }
        }

        static void ShowSum(List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Текущая сумма введенных чисел: {sum}");
        }
    }
}
