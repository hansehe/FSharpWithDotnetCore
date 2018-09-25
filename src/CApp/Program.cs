using System;

namespace CApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nice command-line arguments! Here's what JSON.NET has to say about them:");
            foreach (var arg in args)
            {   
                var jsonArg = Library.GetJsonNetJson(arg);
                Console.WriteLine(jsonArg);
            }
        }
    }
}
