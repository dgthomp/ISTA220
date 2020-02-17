# **Class: ISTA220**
## **Name:**   Daniel Thompson
## **Assignment:** ISTA220programmingexercise5*
## **Date:** February 17, 2020

~~~
using System;

namespace exercise05
{
    class Program
    {
        //Part 1
        public static int ArrayCount(int[] arr)
        {
            int len = arr.Length;
            return len;

        }
        public static int ArraySum(int[] arr)
        {
            int len = arr.Length;
            int sum = 0;
            for (int i = 0; i <= len - 1; i++)
            {
                sum += arr[i];
            }
            return sum;

        }
        public static double Avg(int[] arr)
        {
            int sum = 0;
            double len = arr.Length;
            for (int i = 0; i <= len - 1; i++)
            {
                sum += arr[i];
            }
            double avg = sum / len;
            return avg;

        }
        //Part 2
        public static void ArrayReverse(int[] arr)
        {

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }    //Part 3
        public static void ArrayRotate(int[] arr, string d = "", int p = 0)
        {

            Console.Write("Enter direction to rotate array:"
                            + "l = left, r = right: ");
            d = Console.ReadLine();
            Console.Write("Enter the number of places"
                            + " to rotate array: ");
            p = int.Parse(Console.ReadLine());

            if (d == "l")//Left Rotate
            {
                int len = arr.Length;
                for (int i = 0; i < p; i++)
                {
                    int temp = arr[0];
                    for (int j = 1; j < len; j++)
                    {
                        arr[j - 1] = arr[j];
                    }
                    arr[len - 1] = temp;
                }
                for (int i = 0; i < len; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            else if (d == "r")//Right Rotate
            {
                int len = arr.Length;
                for (int i = len - 1; i > len - 1 - p; i--)
                {
                    int temp = arr[len - 1];
                    for (int j = len - p; j >= 0; j--)
                    {
                        arr[j + 1] = arr[j];
                    }
                    arr[0] = temp;
                }
                for (int i = 0; i < len; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
                Console.Write("Enter direction to rotate array:"
                            + "l = left, r = right: ");
            }
            return;
        }
        private static void ArraySort(int[] arr)
        {
            int len = arr.Length;

            for (int j = 0; j < len-1; j++)
            {
                for (int i = 0; i < len-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i+1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }



        }
        static void Main(string[] args)
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("Part 1: counts, sums and average the elements in an array.\n");
            Console.WriteLine($"Array A count = {ArrayCount(arrayA)}, Array A Sum = {ArraySum(arrayA)}, Array A average is {Avg(arrayA)}\n");
            Console.WriteLine($"Array B count = {ArrayCount(arrayB)}, Array B Sum = {ArraySum(arrayB)}, Array A average is {Avg(arrayB)}\n");
            Console.WriteLine($"Array C count = {ArrayCount(arrayC)}, Array C Sum = {ArraySum(arrayC)}, Array A average is {Avg(arrayC)}\n\n");

            Console.WriteLine("Part 2: Reverse Arrays\n");
            Console.WriteLine("Reverse Array A\n");
            Console.Write("Reverse array is ");
            ArrayReverse(arrayA);
            Console.WriteLine("\n");
            Console.WriteLine("Reverse Array B\n");
            Console.Write("Reverse array is ");
            ArrayReverse(arrayB);
            Console.WriteLine("\n");
            Console.WriteLine("Reverse Array C\n");
            Console.Write("Reverse array is ");
            ArrayReverse(arrayC);
            Console.WriteLine("\n\n");
            Console.WriteLine("Part3: Rotate Arrays\n");
            Console.WriteLine("Rotate Array A two Places to the left\n");
            ArrayRotate(arrayA);
            Console.WriteLine("\nRotate Array B two Places to the right\n");
            ArrayRotate(arrayB);
            Console.WriteLine("\nRotate Array C four Places to the left\n");
            ArrayRotate(arrayC);
            Console.WriteLine("\n\n");
            Console.WriteLine("Part 3: Sort Array\n");
            Console.WriteLine("Sort Array C\n");
            ArraySort(arrayC);

        }

    }

}


~~~
