using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Exercises.MyExercises
{
    internal class PrimeNumberValidator
    {
        public void Test()
        {
            if(CheckNumber(5))
            {
                Console.Write("Podana liczba nie jest liczbą pierwszą");
            }
            else
            {
                Console.Write("Podana liczba jest liczbą pierwszą");
            }
        }

        public bool CheckNumber(int numb)
        {
            int m = numb / 2;
            for (int i = 2; i <= m; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
