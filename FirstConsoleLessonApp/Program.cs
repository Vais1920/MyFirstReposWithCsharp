using System;
using System.Text;

namespace FirstConsoleLessonApp
{
    class Program
    {
        /// <summary>
        /// Test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestMethod();
            CreateArray();
            int number;
            number = 0;
        }

        private static void CreateArray()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);
            }
        }

        private static void TestMethod()
        {
            Console.WriteLine("Введите число");

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    Console.WriteLine("Вы ввели " + value);
                    break;
                }
                else
                {
                    Console.WriteLine("Введите число");
                }
            }
        }
    }
}
