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
            //TestMethod();
            //CreateArray();
            int a = 10;
            CreateMethodWithReferenceParams(ref a, 7);
            Console.WriteLine(a);
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


        /*
         * Ключевое слово ref позволяет передать в метод параметр не по значению, а по ссылке => если параметр
         * изменится, то и значение переменной, которая была передана в качестве параметра, тоже изменится.
         * Это продемонстрировано в методе CreateMethodWithReferenceParams.
         */
        private static int CreateMethodWithReferenceParams(ref int a, int b)
        {
            return a += b;
        }
    }
}
