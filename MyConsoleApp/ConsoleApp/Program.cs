using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Trace.WriteLine("テストメッセージ");

            Console.WriteLine("Hello C# World! ");

            String firstFriend = "Maria";
            String secondFriend = "Andy";

            Console.WriteLine("########################################");
            Console.WriteLine("Hello" + firstFriend);
            Console.WriteLine("Hello" + firstFriend);
            Console.WriteLine($"Hello {firstFriend}");

            Console.WriteLine($"The name  {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name  {secondFriend} has {secondFriend.Length} letters");

            Console.WriteLine("########################################");
            String greeting = "     Hello C# World!    ";
            Console.WriteLine($"[{greeting}]");

            Console.WriteLine(greeting.Replace("Hello", "Greeting"));

            Console.WriteLine("########################################");
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.WriteLine(trimmedGreeting.ToLower());
            Console.WriteLine(trimmedGreeting.ToUpper());

            Console.WriteLine("########################################");
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
        }
    }
}
