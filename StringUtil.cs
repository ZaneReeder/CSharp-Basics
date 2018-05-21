using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class StringUtil
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length > maxLength)
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>(); //dynamic size

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                return String.Join(" ", summaryWords) + "...";
            }
            else
                return text;
        }
    }
}
