using System;


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
            int inputNumber = 0;
            int quitNumber = -1;
            bool numberParsed = false;

            while (!numberParsed)
            {
                Console.WriteLine("Пожалуйста, введите натуральное число больше 0 или букву q для выхода: ");
                inputString = Console.ReadLine();

                if (inputString == "q")
                    return quitNumber;

                numberParsed = Int32.TryParse(inputString, out inputNumber);
                
                if (inputNumber <= 0)
                    numberParsed = false;
            }

            return inputNumber;
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
            Console.WriteLine($"Сумма чисел от 1 до {inputNumber} = {Sum(inputNumber)}");
            Console.WriteLine($"Максимальное четное число меньше {inputNumber} = {MaxEven(inputNumber)}");
            Console.ReadLine();
        }
    }
}
