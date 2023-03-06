using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Exercises.MyExercises
{
    internal class DateCalc
    {
        public void DaysFromMyBirthday(DateTime birthday)
        {
            var today = DateTime.Now;
            Console.WriteLine(birthday);
            Console.WriteLine(today);

            TimeSpan howManyDays = today - birthday;
            Console.WriteLine(howManyDays.TotalHours + " hours old");
            Console.WriteLine(howManyDays.TotalDays + " days old");
        }
    }
}
