// See https://aka.ms/new-console-template for more information

// Implicit using directives
// using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks;

namespace Basics
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program started at" + DateTime.Now);
        Console.WriteLine("Write your name: ");

        var name = Console.ReadLine();
        Console.WriteLine($"\nHello {name}");

        Console.WriteLine($"\nPress any key to end this program: ");
        Console.ReadKey(true);
    }
  }
}


