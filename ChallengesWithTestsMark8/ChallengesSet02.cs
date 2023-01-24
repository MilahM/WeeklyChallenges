using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           
            return char.IsLetter(c);

            //var alpha = "abcdefghijklmnopqrstuvwxyz";
            //return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'); can also do this way
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            //bool countIsEven = true; not necessary
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            bool isEven = true;
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            bool isOdd = true;
            if( num % 2 != 0 )
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            if(numbers == null)
            {
                return 0;
            }else if(numbers.Count() == 0 )
            {
                return 0;
            }
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;

        }

        public int Sum(int[] numbers)
        {
            //throw new NotImplementedException();
           if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            return numbers.Sum();

            //return (numbers == null) ? 0 : numbers.Sum(); can also do this way
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Sum();

            //return numbers?.Where(x => x % 2 == 0).Sum() ?? 0; can do this way
            //return (numbers == null) ? 0 : numbers.Where(x => x % 2 == 0).Sum(); can be done this way

        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();
           if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;
            
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();
           if(number < 0)
            {
                return 0;
            }
            return number / 2;
            
        }
    }
}
