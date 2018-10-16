using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 3, 5, 76, 21, 3, 5, 6, 2, 56, 246, 26, 2, 5, 2, 5, 3, 35, 23 };
            //string str = "Hello There Mang";
            //string reversedString = "";

            //array.Sort();
            //reversedString = str.ReverseString();

            //Console.WriteLine(reversedString);

            Point pointOne = new Point(20, 30);
            Point pointTwo = new Point(10, 15);

            Distance distance = pointOne.DistanceTo(pointTwo);

            Console.WriteLine(distance.XDistance);



        }
    }
}
