using System;

class Program
{
    static string RemoveSubstring(string input, int startPos, int length)
    {
        if (startPos < 0 || startPos >= input.Length || length < 0)
            return input;

   
        int endPos = startPos + length;
        if (endPos > input.Length)
            endPos = input.Length;

        
        string result = input.Substring(0, startPos) + input.Substring(endPos);

        return result;
    }

    static void Main()
    {
        string originalString = "Hello, world!";
        string modifiedString = RemoveSubstring(originalString, 7, 5);
        Console.WriteLine(modifiedString); 
    }
}
