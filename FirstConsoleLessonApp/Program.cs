using System;
using System.Text;

namespace FirstConsoleLessonApp
{
    class Program
    {
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

        /*
         * Метод, реализующий деление.
         * Если можно поделить, то возвращает true, иначе false и результат равен 0.
         * Результат деления записывается в out параметр a.
         * Можно указать больше одного out параметра.
         * Out параметр служит как ещё одно возвращаемое значение из метода, 
         * его обязательно нужно инициализировать.
         */
        private static bool Divide(decimal a, decimal b, out decimal result)
        {
            result = 0;
            if (b == 0)
            {
                return false;
            }
            result = a / b;
            return true;
        }


        /*
         * in параметры нельзя изменять в теле метеда.
         */ 
        private static bool Divide1(in decimal a, in decimal b, out decimal result)
        {
            result = 0;
            if (b == 0) return false;
            result = a / b;
            return true;
        }


        /*
         * ключевое слово params позволяет передавать в метод бесконечное количество аргументов.
         * params параметр должен находится после всех параметров метода, а так же в методе может быть только
         * один аргумент params.
         */ 
        private static void PrintArray(int a, params int[] numbers)
        {
            Console.WriteLine("a = " + a);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        /// <summary>
        /// Test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TestMethod();
            //CreateArray();
            //int a = 10;
            //CreateMethodWithReferenceParams(ref a, 7);
            //Console.WriteLine(a);
            //decimal a = 10;
            //bool result = Divide(10, 3, out a);
            //if (result)
            //Console.WriteLine("a = " + a);
            //bool returnResult = Divide1(a, 0, out decimal result);
            //if (returnResult)
            //    Console.WriteLine(result);
            //else Console.WriteLine("Неверное значение b (0)");
            //PrintArray(10, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            //Printer.Print("string");

            Person person;
            person = new Person();

            person.Name = "Vitalik";
            Console.WriteLine(person._name);
        }
    }
}
