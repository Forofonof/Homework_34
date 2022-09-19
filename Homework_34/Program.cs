using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        const string exit = "exit";
        const string sum = "sum";
        bool isWork = true;

        List<int> arrayNumbers = new List<int>();

        while (isWork)
        {
            Console.WriteLine($"Введите число или команду {sum} / {exit}");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case sum:
                    SumUpNumbers(arrayNumbers);
                    break;

                case exit:
                    DoExit(ref isWork);
                    break;

                default:
                    AddNumbersUser(userInput, arrayNumbers);
                    break;
            }
        }
    }

    static void AddNumbersUser(string userInput, List<int>arrayNumbers)
    {
        if (Int32.TryParse(userInput, out int numbers))
        {
            arrayNumbers.Add(numbers);
        }
        else
        {
            Console.WriteLine("Введено неверное значение.");
        }
    }

    static void SumUpNumbers(List<int>arrayNumbers)
    {
        int arraySum = 0;

        foreach (int arrayNumbersInList in arrayNumbers)
        {
           arraySum += arrayNumbersInList;
        }

        Console.WriteLine($"Сумма массива: {arraySum}");
    }

    static void DoExit(ref bool isWork)
    {
        Console.Clear();
        Console.WriteLine("Работа программы завершена!");

        isWork = false;
    }
}