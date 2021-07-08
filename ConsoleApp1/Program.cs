using System;

namespace ConsoleApp1
{
    class Program
	{
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 86, 495, 41 };
            int length = array.Length;

            for (int i = 0; i < length; i++)
                Console.Write(array[i] + " ");


            Console.WriteLine();
            Console.WriteLine(length);
            Console.ReadKey();


        }
	}
}
