using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
        }


        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            int[] odds = Enumerable.Range(1, 100).ToArray();
            return odds.Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();

            //words = Array.ConvertAll(words, x => x.ToUpper());

            //words = words.Select(x => x.ToUpper()).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            

        }
    }
}
