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

            if("Lorem".Equals("lorem", StringComparison.CurrentCultureIgnoreCase))
            {

            }
        }

        public int GetWordsCountWithinSentence(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return 0;
            int countWords = sentence.Split(' ').Count();
            return countWords;
        }


        private static string GetTextUntilComma(string sentence)
        {
            return sentence.Substring(0, sentence.IndexOf(','));
        }
        private static string GetTextAfterComma(string sentence)
        {
            var commaIndex = sentence.IndexOf(',');
            return sentence.Substring(commaIndex + 1);
        }

        private static string GetThirdWord(string sentence)
        {
            return sentence.Split(' ').Skip(2).FirstOrDefault();
        }

        private static string GetEverySecondWord(string sentence)
        {
            return string.Empty;
        }
    }
}
