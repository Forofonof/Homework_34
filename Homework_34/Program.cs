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

            if (userInput.ToLower() != exit && userInput.ToLower() != sum)
            {
                int numbers = Convert.ToInt32(userInput);
                arrayNumbers.Add(numbers);
            }
            else if (userInput.ToLower() == sum)
            {
                int arraySum = 0;

                foreach (int arrayNumbersInList in arrayNumbers)
                {
                    arraySum += arrayNumbersInList;
                }

                Console.WriteLine($"Сумма массива: {arraySum}");
            }
            else if (userInput.ToLower() == exit)
            {
                isWork = false;
            }
        }
    }
}