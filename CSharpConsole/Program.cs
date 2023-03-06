using System;
using System.Globalization;
using System.IO;
using CSharpConsole.Exercises.MyExercises;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var strInput = Console.ReadLine();
            var strInput = args[0];

            if (! int.TryParse(strInput, out int input))
            {
                Console.WriteLine("To nie jest liczba");
                return;
            }

            var dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dd.MM.yyyy hh:mm:ss"));

            dt.ToUniversalTime();
            

            var ci = new CultureInfo("pl-pl");

            DateTime.Parse(strInput);


            var ts = new TimeSpan(2,0,0);
           


            var fibo = new Fibonacci();

            if(fibo != null)
            {
                fibo.GetNextFibo(input);
            }

            var result = fibo.GetNextFibo(input);

            Console.WriteLine(result);
        }
        private void Execute(Fibonacci fi)
        {
            if(fi != null)
                fi.GetNextFibo(1000);
        }
    }
}
