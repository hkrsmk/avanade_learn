// to compile on Linux, run mcs test.cs
// then ./test.exe to run the exe file

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");

            // the app keeps exiting on its own, so to stop that, I included this line below
            Console.ReadLine();
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}