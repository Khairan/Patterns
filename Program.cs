﻿using System;


namespace Lesson1
{
    class Program
    {
        static int Factorial(int inputNumber)
        {
            int factorial = 1;
            
            for (int i = 1; i <= inputNumber; i++)
            {
                factorial = factorial * i;
            }
            
            return factorial;
        }

        static int Sum(int inputNumber)
        {
            int summ = 0;
            
            for (int i = 1; i <= inputNumber; i++)
            {
                summ = summ + i;
            }
            
            return summ;
        }

        static int MaxEven(int inputNumber)
        {
            if (inputNumber % 2 == 0)
                return inputNumber - 2;
            else 
                return inputNumber - 1;
        }

        static int ReadString()
        {
            String inputString;
            uint inputNumber = 0;
            int quitNumber = -1;
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine("Пожалуйста, введите натуральное число или букву q для выхода: ");
                inputString = Console.ReadLine();

                if (inputString == "q")
                {
                    return quitNumber;
                }

                flag = UInt32.TryParse(inputString, out inputNumber);
            }

            return (int)inputNumber;
        }

        static void Main()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа.");

            int inputNumber = ReadString();
            if (inputNumber < 0)
            {
                return;
            }

            Console.WriteLine($"Факториал {inputNumber} = {Factorial(inputNumber)}"); 
            Console.WriteLine($"Сумма всех чисел от 0 до {inputNumber} = {Sum(inputNumber)}");
            Console.WriteLine($"Максимальное четное число меньше {inputNumber} = {MaxEven(inputNumber)}");
            Console.ReadLine();
        }
    }
}
