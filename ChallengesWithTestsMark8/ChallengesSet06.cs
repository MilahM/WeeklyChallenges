using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();
            bool wordsContains = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();
                wordsContains = lowerCase.Contains(word);
            }
            else
            {
                wordsContains = words.Contains(word);
            }

            return wordsContains;

            //return ignoreCase ? words?.Select(x => x?.ToLower()).Contains(word) ?? false : words?.Contains(word) ?? false;
        }

        public bool IsPrimeNumber(int num)
        {
            //throw new NotImplementedException();
            var isPrime = false;

            if(num >= 0)
            {
                if(num % 2 != 0 && num % 3 != 0) 
                {
                    isPrime = true;
                }

            }

            if(num == 2 || num == 3)
            {
                isPrime = true;
            }

            if(num == 1)
            {
                isPrime = false;
            }

            return isPrime;
           
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //throw new NotImplementedException();

            //int index = -1;
            //bool uniqueIndex;

            //for (var i = 0; i < str.Length; i++)
            //{
            //    uniqueIndex = true;

            //    for (var j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j] && i != j)
            //        {
            //            uniqueIndex = false;
            //        }
            //    }

            //    if (uniqueIndex == true) 
            //    {
            //        index = i;
            //    }
            //}

            //return index;

            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            //throw new NotImplementedException();
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //throw new NotImplementedException();

            //List<double> nthElement = new List<double>();

            //if(elements == null || n <= 0 || n > elements.Count)
            //{
            //    return nthElement.ToArray();
            //}

            //for (var i = n - 1; i < elements.Count; i += n)
            //{
            //    nthElement.Add(elements[i]);
            //}

            //return nthElement.ToArray();

            return (elements == null || n <= 0) ? new double[0] : elements.Where((item, index) => (index + 1) % n == 0).ToArray();  
        }
    }
}
