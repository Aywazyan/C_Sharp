using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string text = Console.ReadLine();

        bool isPalindrome = true;

        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Is Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}