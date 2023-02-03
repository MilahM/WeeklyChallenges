using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            //var sum = 0;

            //foreach (var item in numbers)
            //{
            //    if(item % 2 == 0)
            //    {
            //        sum += item;
            //    }
            //    if(item % 2 != 0)
            //    {
            //        sum -= item;
            //    }
            //}
            //return sum;

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            //var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };

            //return list.Min();

            return new List<string>() { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //throw new NotImplementedException();
            //var list = new List<int>() { number1, number2, number3, number4 };

            //return list.Min();

            return new List<int>() { number1, number2, number3, number4 }.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                );
        }

        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();
            return double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            //var amount = objs.Length;
            //var majority = (objs.Length / 2) + 1;

            //var count = 0;

            //foreach (var item in objs)
            //{
            //    if (objs == null)
            //    {
            //        count++;
            //    }
            //}

            //return count >= majority;

            return Convert.ToDouble(objs.Where(x => x == null).Count()) / Convert.ToDouble(objs.Length) > .5;
        }

        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            //double sum = 0;
            //double count = 0;

            //if(numbers == null)
            //{
            //    return 0;
            //}

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        sum += number;
            //        count++;
            //    }
            //}

            //if(count > 0)
            //{
            //    return sum / count;
            //}
            //return 0;

            return (numbers?.Where(x => x % 2 == 0).Count() > 0) ? numbers.Where(x => x % 2 == 0).Average() : 0;
        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }

            int result = 1;

            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;

            //return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((f, s) => f * s);

        }
    }
}
