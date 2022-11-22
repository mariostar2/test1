using System;
using System.Collections.Generic;
using System.Linq;

namespace test1
{
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 5, 6, 7, 8 };

            int[] except = array1.Except(array2).ToArray();
            int[] intersection = array1.Intersect(array2).ToArray();
            int[] union = array1.Union(array2).ToArray();

            List<int> list = new List<int>();
            int[] numbers = { 2, 1, 3, 4, 1 };
            for(int i = 0; i<numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; i++)
                {
                    list.Add(numbers[i] + numbers[i]);
                }
            
            }
            //array = list.Distinct().OrderBy(n => n).ToArray();
            

            string result = soluction("Zbcdefg");
            Console.WriteLine(result);
        }

        public static string soluction(string s)
        {          
           /* char[] array = s.ToCharArray();
            Array.Sort(array);
            array.Reverse();
           string result = string.Concat(array);
            */

            return new string(s.OrderByDescending(word =>word).ToArray());
            
           
        }
        public static int[] soluction2(int[] arr)
        {
            if (arr.Length <= 1)
                return new int[] { -1 };

            return arr.Where(num => num != arr.Min()).ToArray();
            /*int min = arr.Min();
            List<int> list = new List<int>();*/
           
           /* list.Remove(arr.Min());
            return list.ToArray();*/
        }
    }
}       
