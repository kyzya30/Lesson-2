using System;

namespace HW_CSharp_18._08_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 7, 3, 7, 4, 10, 99 };
            MyReverse(array); 
        }
        static int[] MyReverse(int[] array)
        {
            int[] tempArray =new int[array.Length];
            int counter = array.Length-1;

            Console.WriteLine("Current array:");
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
                tempArray[counter] = arr;

                counter--;
            }
            array = tempArray;
            Console.WriteLine("After reverse:");
            foreach (int tmpArr in array)
            {
                Console.WriteLine(tmpArr);
            }
            return array; 
        }
    }
}
