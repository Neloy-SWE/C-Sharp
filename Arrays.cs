using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class Arrays
    {
        public void singleArray()
        {
            int[] arr1 = new int[3]; // initially all value will be zero
            Console.WriteLine("Before initialize value check:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            Console.WriteLine("After initialize value check:");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i+1;
                Console.WriteLine(arr1[i]);
            }
            // checking value again: 
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = i + 1;
            //    Console.WriteLine(arr1[i]);
            //}

            // both declare and initialize:
            int[] arr2 = new int[3]{4,5,6};
            Console.WriteLine("Checking 2nd array:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            // another way to declare and initialize:
            int[] arr3 = { 7,8,9 };
            Console.WriteLine("Checking 3rd array:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            Console.WriteLine("Print using foreach loop:");
            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }
        }

        public void passArray(int[] arr)
        {
            Console.WriteLine("Printing values from parameter:");
            foreach(int i in arr)
            {
                   Console.WriteLine(i);
            }
        }

        public void mutlidimensionalArray()
        {
            Console.WriteLine("Multidimensional array:");
            int[,] arr = { { 1, 2,3,4 }, { 4, 5,6,7}, {7,8,9 ,10} };

            // to get row count use arr.GetLength(0) and to get column count use arr.GetLength(1)
            for( int i=0; i< arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                 Console.WriteLine();
            }
        }

        public void jaggedArray()
        {
            Console.WriteLine("Jagged array: ");
            int[][] arr1 = new int[2][];
            arr1[0] = new int[2] {1,2};
            arr1[1] = new int[4] {3,4,5,6};

            for (int i = 0; i<arr1.Length; i++)
            {
                for (int j = 0; j<arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("jagged array (both declare and initial): ");

            int[][] arr2 = new int[3][]{
                new int []{1,2},
                new int []{3,4,5},
                new int []{7}
                };

            for (int i = 0; i<arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
