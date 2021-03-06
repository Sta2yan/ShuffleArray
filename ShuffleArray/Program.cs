using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Массив до перемешивания:");
            ShowArray(numbers);

            Shuffle(numbers);

            Console.WriteLine("\nМассив после перемешивания:");
            ShowArray(numbers);
        }

        static void Shuffle(int[] numberArray)
        {
            Random random = new Random();
            int index;
            int tempNumber;

            for (int currentIndex = 0; currentIndex < numberArray.Length; currentIndex++)
            {
                index = random.Next(0, numberArray.Length - 1);
                if (currentIndex != index)
                {
                    tempNumber = numberArray[currentIndex];
                    numberArray[currentIndex] = numberArray[index];
                    numberArray[index] = tempNumber;
                }
            }
        }

        static void ShowArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
}
}