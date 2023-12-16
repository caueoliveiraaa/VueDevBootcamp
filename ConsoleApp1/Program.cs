// -> Implicit using directives:
// using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Basics {
    class Program {
        static void Main(string[] args) {
            Console.Clear();
            try {
                var driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.google.com/");
                Thread.Sleep(5000);
            } catch (Exception e) {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}
