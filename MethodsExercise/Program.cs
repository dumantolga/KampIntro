using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            ////var result = Add2(20,30);
            //var result = Add3(20);


            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add4(ref number1,number2);

            //int number1;
            //int number2 = 100;

            //var result3 = Add5(out number1, number2);
            //Console.WriteLine(result3);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(5, 6));
            Console.WriteLine(Multiply(5, 6, 2));

            Console.WriteLine(Add6(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        //Parametreli metot
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //Default parametreli metot
        static int Add3(int number1, int number2 = 30)//default değer sonda olmalı
        {
            var result = number1 + number2;
            return result;
        }

        //Ref Keyword
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Out Keyword
        static int Add5(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add6(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
