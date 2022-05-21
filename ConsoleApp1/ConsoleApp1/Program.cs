using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Shuffle(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int number = random.Next(i + 1);
                int buffer = array[number];
                array[number] = array[i];
                array[i] = buffer;
            }
        }
    }
}