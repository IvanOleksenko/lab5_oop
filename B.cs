using System;

class Program
{
    static int FindFirstOccurrence(string input, string substring)
    {
        int n = input.Length;
        int m = substring.Length;

        for (int i = 0; i <= n - m; i++)
        {
            bool match = true;
            for (int j = 0; j < m; j++)
            {
                if (input[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                return i;
        }

        return -1;
    }

    static int FindLastOccurrence(string input, string substring)
    {
        int n = input.Length;
        int m = substring.Length;

        for (int i = n - m; i >= 0; i--)
        {
            bool match = true;
            for (int j = 0; j < m; j++)
            {
                if (input[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                return i;
        }

        return -1;
    }

    static void Main()
    {
        string originalString = "Hello, world! Hello again!";
        int firstIndex = FindFirstOccurrence(originalString, "Hello");
        int lastIndex = FindLastOccurrence(originalString, "Hello");

        Console.WriteLine($"Позиція першого входження: {firstIndex}");
        Console.WriteLine($"Позиція останнього входження: {lastIndex}");
    }
}
