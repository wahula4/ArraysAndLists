using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Length
            var numbers = new[] { 2, 5, 3, 7, 1, 12 };
            Console.WriteLine("length: " + numbers.Length);

            //IndexOF()
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: " + index);

            //Clear() clearing sets them to 0, null or false
            // we are clearing 2 numbers starting at 0 index
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy");
            foreach (var item in another)
                Console.WriteLine(item);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var item in numbers)
                Console.WriteLine(item);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach(var item in numbers)
                Console.WriteLine(item);

            var digits = new List<int>() { 1, 2, 3, 4 };
            digits.Add(1);
            digits.AddRange(new int[3] { 5, 6, 7 });
            Console.WriteLine("Digits List");
            foreach (var digit in digits)
                Console.WriteLine(digit);

            // finds the first 1
            Console.WriteLine("Index of 1: " + digits.IndexOf(1));
            // finds the last 1
            Console.WriteLine("Last index of 1: " + digits.LastIndexOf(1));

            Console.WriteLine("Count: " + digits.Count);

            digits.Remove(1);
            Console.WriteLine("Remove");
            // removes only the first 1
            foreach (var digit in digits)
                Console.WriteLine(digit);

            // to remove all the 1's
            Console.WriteLine("Remove all 1's");
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] == 1)
                    digits.Remove(digits[i]);
            }
            // cannot remove items for a list inside of a foreach loop
            foreach (var digit in digits)
                Console.WriteLine(digit);

            digits.Clear();
            Console.WriteLine("Count: " + digits.Count);
        }
    }
}
