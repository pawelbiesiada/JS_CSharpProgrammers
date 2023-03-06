using System;
using System.Diagnostics;
using System.Text;

namespace CSharpConsole.Exercises.String
{
    public class StringConcat
    {
        static void Main()
        {
            var test = new StringConcat();
            var loopCount = 150_000;
            var timer = Stopwatch.StartNew();

            test.ConcatUsingString(loopCount);
            Console.WriteLine($"Concatenating strings took {timer.ElapsedMilliseconds} ms.");
            timer.Restart();
            test.ConcatWithStringBuilder(loopCount);
            Console.WriteLine($"Concatenating StringBuilder took {timer.ElapsedMilliseconds} ms.");
            timer.Reset();
            Console.ReadKey();

        }

        public void ConcatUsingString(int count)
        {
            var str = string.Empty;
            for (int i = 0; i < count; i++)
            {
                str += " ";  //str = str + " "
            }
        }

        public void ConcatWithStringBuilder(int count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(" ");
            }
            var text = sb.ToString();
        }
    }
}
