using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Print1To255();

            PrintOdd1To255();
            SumNumbers0To255();

            PrintArray(new int[] { 1, 3, 5, 7, 9, 13 }, true);
            Console.WriteLine();

			Console.WriteLine("Find Max: Write a program (sets of instructions) that takes ");
            Console.WriteLine("     any array and prints the maximum value in the array.");
			Console.WriteLine("      Your program should also work with a given array that has ");
            Console.WriteLine("     all negative numbers (e.g. [-3, -5, -7]),");
			Console.WriteLine("      or even a mix of positive numbers, negative numbers ");
            Console.WriteLine("     and zero.");
			var Pos = new int[] { 1, 3, 5, 7, 9, 13 };
            var Mix = new int[] { 1, -3, 5, -7, 9, -13 };
            var Neg = new int[] { -1, -3, -5, -7, -9, -13 };
			FindMaxOfArray(Pos);
			FindMaxOfArray(Mix);
			FindMaxOfArray(Neg);
			Console.WriteLine();

			Console.WriteLine("Get Average: Write a program that takes an array, and ");
            Console.WriteLine("     prints the AVERAGE of the values in the array. ");
            Console.WriteLine("     For example for an array [2, 10, 3], your program ");
            Console.WriteLine("     should print an average of 5.");
            Console.WriteLine("     Again, make sure you come up with a simple ");
            Console.WriteLine("     base case and write instructions to solve that base case first, ");
            Console.WriteLine("     then test your instructions for other complicated ");
            Console.WriteLine("     cases.You can use a count function with this assignment.");
            FindAvgOfArray(new int[] { 2, 10, 3 });
			Console.WriteLine();

			Console.WriteLine("Array with Odd Numbers: Write a program that creates ");
            Console.WriteLine("     an array 'y' that contains all the odd numbers");
			Console.WriteLine("     between 1 to 255. When the program is done, 'y' ");
            Console.WriteLine("     should have the value of[1, 3, 5, 7, ... 255].");
			PrintArray(GenArray1To255());
			Console.WriteLine();

			Console.WriteLine("Greater than Y: Write a program that takes an array and ");
            Console.WriteLine("     returns the number of values in that array");
			Console.WriteLine("     whose value is greater than a given value y. ");
            Console.WriteLine("     For example, if array = [1, 3, 5, 7] and y = 3.");
			Console.WriteLine("     After your program is run it will print 2 (since there ");
            Console.WriteLine("     are two values in the array that are greater than 3).");
            GreaterThanY(new int[] { 1, 3, 5, 7 }, 3);
			Console.WriteLine();

            Console.WriteLine("Square the Values: Given any array x, say[1, 5, 10, -2], ");
            Console.WriteLine("     create an algorithm that multiplies each value in ");
            Console.WriteLine("     the array by itself.  When the program is done, the ");
            Console.WriteLine("     array x should have values that have been squared, ");
            Console.WriteLine("     say[1, 25, 100, 4].");
            var result = SquareTheValues(new int[] { 1, 5, 10, -2 });
			Console.WriteLine();

			Console.WriteLine("Eliminate Negative Numbers: Given any array x, ");
            Console.WriteLine("     say[1, 5, 10, -2], create an algorithm that  replaces ");
            Console.WriteLine("     any negative number with the value of 0. ");
			Console.WriteLine("     When the program is done, x should have no negative ");
            Console.WriteLine("     values, say[1, 5, 10, 0].");
			result = RemoveNegativeValuesValues(new int[] { 1, 5, 10, -2 });
			Console.WriteLine();

			Console.WriteLine("Min, Max, and Average: Given any array x, say[1, 5, 10, -2], create an algorithm that prints");
            Console.WriteLine("     the maximum number in the array, the minimum value in the array, and the average");
            Console.WriteLine("     of the values in the array.");
            MinMaxAverageOfArray(new int[] { 1, 5, 10, -2 });
			Console.WriteLine();

			Console.WriteLine("Shifting the values in an array: Given any array x, say[1, 5, 10, 7, -2], create an");
			Console.WriteLine("     algorithm that shifts each number by one to the front and adds '0' to the end.");
			Console.WriteLine("     For example, when the program is done,  if the array [1, 5, 10, 7, -2] is ");
			Console.WriteLine("     passed to the function, it should become[5, 10, 7, -2, 0].");
            ShiftAllForwardOne(new int[] { 1, 5, 10, 7, -2 });
            Console.WriteLine();

			Console.WriteLine("Number to String: Write a program that takes an array of numbers and replaces any negative");
			Console.WriteLine("     number with the string 'Dojo'. For example, if array x is initially[-1, -3, 2] your");
			Console.WriteLine("     function should return an array with values ['Dojo', 'Dojo', 2].");
            ReplaceNegativesWithDojo(new object[] { -1, -3, 2 });
		}



        private static void Print1To255()
        {
            Console.WriteLine("Print 1-255 :Write a program(sets of instructions) that would print all the numbers from 1 to 255.");
            for (var i = 1; i <= 255; i++)
                Console.Write(i + " ");
            Console.WriteLine();
        }
	
        private static void PrintOdd1To255()
		{
			Console.WriteLine("Print odd numbers between 1-255: Write a program that would print all the odd numbers from 1 to 255.");
			for (var i = 1; i <= 255; i += 2)
				Console.Write(i + " ");
			Console.WriteLine();
		}

		private static void SumNumbers0To255()
		{
			Console.WriteLine("Print Sum: Write a program that would print the numbers from 0 to 255 but this time, ");
            Console.WriteLine("     it would also print the sum of the numbers that have been printed so far.");
			int sum = 0;
			for (var i = 0; i <= 255; i++)
			{
				sum += i;
				Console.WriteLine("New number: " + i + " Sum: " + sum);
			}
		}

        private static void PrintArray(int[] arr, bool preamble = false)
        {
            if (preamble)
            {
                Console.WriteLine("Iterating through an Array: Given an array X, say[1, 3, 5, 7, 9, 13],");
                Console.WriteLine("     write a program that would iterate through each member of the array ");
                Console.WriteLine("     and print each value on the screen.");
            }
			Console.Write(" [ ");
			foreach (int aNum in arr) {
                Console.Write(aNum + ", ");
            }
            Console.Write("]");
		}

		private static void PrintArray(object[] arr)
		{
			Console.Write(" [ ");
			foreach (object anObj in arr)
			{
                if (anObj is string)
				Console.Write(anObj as string + " ");
				if (anObj is int)
                    Console.Write("'" + ((int)anObj).ToString() + "', ");
			}
			Console.Write("]");
		}

		private static void FindMaxOfArray(int[] anIntArray)
        {
            if (0 == anIntArray.Length)
            {
                Console.Write("  I cannot evaluate an empty array.");
                return;
            }
			int max = anIntArray[0];
			for (int i = 1; i < anIntArray.Length; i++)
			{
				if (max < anIntArray[i])
					max = anIntArray[i];
			}
			Console.Write("     The Max value of ");
			PrintArray(anIntArray);
			Console.WriteLine(" is " + max);
		}
		private static void FindAvgOfArray(int[] anIntArray)
		{
			if (0 == anIntArray.Length)
			{
				Console.Write("  I cannot evaluate an empty array.");
				return;
			}
            int sum = 0;
			for (int i = 0; i < anIntArray.Length; i++)
			{	
				sum += anIntArray[i];
			}
			Console.Write("     The Avg value of ");
			PrintArray(anIntArray);
            Console.WriteLine(string.Format(" is {0}." ,sum / (float) anIntArray.Length ));
		}

		private static int[] GenArray1To255()
		{
            int[] answer = new int[128];
            for (var i = 0; i < 128; i++)
                answer[i] = (2 * i) + 1;
            return answer;
		}

        private static void GreaterThanY(int[] anIntArry, int y) {
            int counter = 0;
            foreach (var item in anIntArry)
            {
                if (item > y) {
                    counter++;
                }
            }
			Console.Write("     The Number of values in array ");
			PrintArray(anIntArry);
			Console.WriteLine(" that is larger than " + y + " is " + counter + ".");
		}

        private static int[] SquareTheValues(int[] SourceArray) 
        {
			Console.Write("  The input array is: ");
			PrintArray(SourceArray);

			for (int i = 0; i < SourceArray.Length; i++)
            {
                SourceArray[i] *= SourceArray[i];
            }
			Console.Write("  The output array is: ");
			PrintArray(SourceArray);

			return SourceArray;
        }

		private static int[] RemoveNegativeValuesValues(int[] v)
		{
			Console.Write("  The input array is: ");
			PrintArray(v);
			for (int i = 0; i < v.Length; i++)
			{
                if (v[i] < 0) 
                    v[i] = 0;
			}
			Console.Write("  The output array is: ");
			PrintArray(v);
			return v;
		}
        private static Dictionary<string, float> MinMaxAverageOfArray(int[] v)
        {
			Console.Write("  The input array is: ");
			PrintArray(v);
            if (v.Length == 0)
                throw new Exception("You are not allowed to pass empty arrays to MinMaxAverageOfArray");
            int min = v[0];
            int max = v[0];
            int sum = 0;
			for (int i = 0; i < v.Length; i++)
			{
                if (v[i] < min)
                    min = v[i];
				if (v[i] > max)
					max = v[i];
                sum += v[i];
			}

			var rtn = new Dictionary<string, float>();
            rtn.Add("Min", (float) min);
			rtn.Add("Max", (float) max);
            rtn.Add("Avg", (float)sum / (float) v.Length);

            Console.WriteLine("  The output dictonary is: ");
            foreach (var entry in rtn)
            {
                Console.WriteLine($"      The {entry.Key} is {entry.Value}.");
            }
			return rtn;
        }

        private static void ShiftAllForwardOne(int[] v) 
        {
			Console.Write("  The input array is: ");
			PrintArray(v);
            Console.WriteLine();
			for (int i = 0; i < v.Length - 1; i++)
            {
                v[i] = v[i + 1];
            }
            v[v.Length - 1] = 0;
			Console.Write("  The output array is: ");
            PrintArray(v);
			Console.WriteLine();
			return;
		}

        private static object[] ReplaceNegativesWithDojo(object[] v)
        {
			Console.Write("  The input array is: ");
			PrintArray(v);
			Console.WriteLine();
			for (int i = 0; i < v.Length - 1; i++)
			{
				v[i] = "dojo";
			}
			Console.Write("  The output array is: ");
			PrintArray(v);
			Console.WriteLine();
			return v;
		}
	}
}
