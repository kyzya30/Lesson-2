using System;


namespace HW_arrays_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] shortArray = { 1, 2, 3, 4, 5 };
            int lastArrayVal = 10; 
            Method(shortArray,lastArrayVal);
        }
        static void Method(int[] array, int value)
        {
            int[] tempArray = new int[array.Length+1];
            for (int i = 0; i <= array.Length-1; i++)
            {
                Console.WriteLine(array[i]);
                tempArray[i] = array[i];

            }
            tempArray[array.Length] = value;
            array = tempArray;
            Console.WriteLine("+1 element");
            foreach (int s in array)
            { Console.WriteLine(s); }
            
        }
    }
}
