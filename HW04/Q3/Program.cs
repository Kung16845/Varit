using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        Dictionary<string, string> productDict = new Dictionary<string, string>();
        Queue<string> keys = new Queue<string>();
        int letterCount = 1, numberCount = 0;
        string input;

        for (int i = 0; i < Math.Pow(26, n) * Math.Pow(10, m); i++)
        {
            string code = GenerateCode(letterCount, numberCount, n, m);
            keys.Enqueue(code);

            input = Console.ReadLine();
            if (input == "Stop")
                break;

            if (productDict.ContainsKey(code))
                productDict[code] = input;
            else
                productDict.Add(code, input);

            numberCount++;
            if (numberCount >= Math.Pow(10, m))
            {
                numberCount = 0;
                letterCount++;
            }
        }

        string searchCode = Console.ReadLine();
        Console.WriteLine(productDict.ContainsKey(searchCode) ? productDict[searchCode] : "Not found!");
    }

    static string GenerateCode(int letterCount, int numberCount, int n, int m)
    {
        string letters = ConvertToBase26(letterCount - 1).PadLeft(n, 'A');
        string numbers = numberCount.ToString().PadLeft(m, '0');
        return letters + numbers;
    }

    static string ConvertToBase26(int number)
    {
        string result = "";
        while (number > 0)
        {
            number--;
            result = (char)('A' + number % 26) + result;
            number /= 26;
        }
        return result;
    }
}
