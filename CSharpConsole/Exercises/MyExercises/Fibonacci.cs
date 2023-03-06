using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Exercises.MyExercises
{
    internal class Fibonacci
    {
        public int GetNextFibo(int number)
        {
            int fibo1 = 1;
            int fibo2 = 1;
            int fiboFinal = 0;

            do
            {
                fiboFinal = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fiboFinal;
            }
            while (fiboFinal < number);

            return fiboFinal;

        }
    }
}
