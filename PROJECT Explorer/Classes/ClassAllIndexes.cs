using System;
using System.Collections.Generic;

namespace HAKROS.Classes
{
    static class ClassAllIndexes
    {

        public static IEnumerable<int> AllIndexesOf(this string input, string query)
        {
            for (var index = 0; ; index += query.Length)
            {
                index = input.IndexOf(query, index);
                if (index == -1)
                    break;
                yield return index;
            }
        }

        public static IEnumerable<int> AllIndexesOfWholeWord(this string input, string query)
        {
            for (var j = 0; j < input.Length && (j = input.IndexOf(query, j, StringComparison.Ordinal)) >= 0; j++)
                if ((j == 0 || !char.IsLetterOrDigit(input, j - 1)) && (j + query.Length == input.Length || !char.IsLetterOrDigit(input, j + query.Length)))
                    yield return j;
            yield return -1;
        }


    }
}
