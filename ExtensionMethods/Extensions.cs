using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static void Sort(this int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    
        public static void Sort(this int[] array, bool reverse = false)
        {
            array.Sort();

            if (reverse)
            {
                Array.Reverse(array);
            }
        }

        public static string ReverseString(this string str)
        {
            string reversedWord = "";

            for (int i = 1; i <= str.Length; i++)
            {
                reversedWord += str.Substring(str.Length - i, 1);
            }

            return reversedWord;
        }

    }
}
