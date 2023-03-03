using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpConsole.Samples.Class;

namespace CSharpConsole.Exercises.String
{
    class StringEx
    {
        private static void Main()
        {
            var someSentence = "Lorem ipsum dolor sit amet,, consectetur adipiscing, elit.";
            var ipsum = someSentence.Substring(6);
            var startIndexofIpsum = someSentence.IndexOf(" ", 6);
        }

        public int GetWordsCountWithinSentence(string sentence)
        {
            return 0;
        }

        private static int GetELettersCount(string sentence, char letterToFind)
        {
            return 0;
        }
        
        private static string GetTextUntilComma(string sentence)
        {
            return string.Empty;
        }
        
        private static string GetThirdWord(string sentence)
        {
            return string.Empty;
        }
        
        private static string GetEverySecondWord(string sentence)
        {
            return string.Empty;
        }
    }
}
