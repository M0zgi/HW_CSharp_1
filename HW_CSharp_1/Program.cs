using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Основы языка С#";
            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 100);

            string messg;
            string finalMessg ="";
            char symbol;
            int countSpace = 0;            

            //Задание 1.

            //Запрос ввода строки пользователем

            Console.WriteLine("Задание 1. \nНаписать программу, которая считывает символы с клавиатуры, " +
                "пока не будет введена точка. \n" +
                "Программа должна сосчитать количество введенных пользователем пробелов.");
            Console.Write("Введиете строрку: ");
            do
            {
                symbol = Console.ReadKey().KeyChar;

                if (symbol == ' ')
                    countSpace++;

                finalMessg += symbol; //сохранение введеных символов в строку, для дальнейшего использования(при необходимости)

            } while (symbol != '.');

            if (countSpace > 0)
            {
                Console.WriteLine("\nСтрока содержит: " + countSpace + " пробела(ов)");
            }

            else
            {
                Console.WriteLine("\nСтрока не содержит пробелов.");
            }

            finalMessg = "";
            //Задание 2.

            Console.WriteLine("-------------------------------------------------------------\n");
            Console.WriteLine("Задание 2. \nВвести с клавиатуры номер трамвайного билета (6-значное число) " +
                "и проверить является ли данный \nбилет счастливым " +
                "(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна \nсумме последних трёх, " +
                "то этот билет считается счастливым).\n");

            Console.Write("Введите номер билета (6-значное число): ");

            try
            {
                int countNum = 0;
                int num;

                int sumNamberFirst = 0;
                int sumNumberSecond = 0;

                do
                {
                    symbol = Console.ReadKey().KeyChar;

                    num = int.Parse(symbol.ToString());

                    if (countNum < 3)
                        sumNamberFirst += num;

                    else
                        sumNumberSecond += num;

                    finalMessg += num; // финальное число
                    countNum++;

                } while (countNum != 6);

                if (sumNamberFirst == sumNumberSecond)
                {
                    Console.WriteLine("\nНомер вашего билета " + finalMessg + " счастливый!");
                }

                else
                {
                    Console.WriteLine("\nНомер вашего билета " + finalMessg + " несчастливый :(");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("\nВведено некорректное значение числа трамвайного билета!");
            }


            Console.WriteLine("-------------------------------------------------------------\n");

            finalMessg = "";
            //Задание 3.

            Console.WriteLine("Задание 3. \nЧисловые значения символов нижнего регистра в коде ASCII отличаются от значений " +
                "символов \nверхнего регистра на величину 32. " +
                "\nИспользуя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует " +
                "\nвсе символы нижнего регистра в символы верхнего регистра и наоборот.\n");

            Console.Write("Введите символы (строку)   : ");
            messg = Console.ReadLine();

            for (int i = 0; i < messg.Length; i++)
            {
                symbol = messg[i];

                if (char.IsLower(messg[i]))
                {
                    symbol -= (char)32;
                }

                if (char.IsUpper(messg[i]))
                {
                    symbol += (char)32;
                }

                finalMessg += symbol;
            }

            Console.WriteLine("Результат после конвертации: " + finalMessg);

            Console.WriteLine("-------------------------------------------------------------\n");

            finalMessg = "";
            //Задание 4.
            Console.WriteLine("Задание 4. \nДаны целые положительные числа A и B (A < B). " +
                "\nВывести все целые числа от A до B включительно; " +
                "\nкаждое число должно выводиться на новой строке; " +
                "\nпри этом каждое число должно выводиться количество раз, равное его значению. " +
                "\nНапример: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:" +
                "\n3 3 3" +
                "\n4 4 4 4" +
                "\n5 5 5 5 5" +
                "\n6 6 6 6 6 6" +
                "\n7 7 7 7 7 7 7");

            uint a, b;

            try
            {
                Console.Write("Введие значение числа a: ");
                messg = Console.ReadLine();
                a = uint.Parse(messg);

                Console.Write("Введие значение числа b: ");
                messg = Console.ReadLine();
                b = uint.Parse(messg);

                if (a > b)
                {
                    Console.WriteLine("Введены неверные значения (a > b)");
                }

                else
                {
                    for (uint i = a; i <= b; i++)
                    {
                        for (uint k = 0; k < i; k++)
                        {
                            Console.Write(i.ToString() + " ");
                        }

                        Console.Write("\n");
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Введены неверные значения");
            }

            Console.WriteLine("-------------------------------------------------------------\n");

            finalMessg = "";

            //Задание 5.
            Console.WriteLine("Задание 5. \nДано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. " +
                "\nНапример, если было введено число 345, то программа должна вывести число 543.");

            try
            {               
                Console.Write("Введие целое число N (> 0)  : ");

                uint n;
                messg = Console.ReadLine();
                n = uint.Parse(messg);                

                finalMessg = new string(messg.ToCharArray().Reverse().ToArray());

                Console.WriteLine("Результат выполнения задания: " + finalMessg);
            }

            catch (Exception)
            {
                Console.WriteLine("Введены неверные значения");
            }           
        }
    }
}
