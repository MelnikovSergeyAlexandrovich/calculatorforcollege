
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cforcollege
{
    internal class Program
    {


        static void Main(string[] args)
        {
            

            string  MathAction ;
            double Factorial = 1, PowResult = 1;


            Console.WriteLine("Какое действие вам нужно?");
            Console.WriteLine
               ("1 Сложение \n" +
                "2 Вычесть первое число из второго \n" +
                "3 Умножение \n" +
                "4 Разделить первое число на второе \n" +
                "5 Найти квадратный корень \n" +
                "6 Найти 1% от числа \n" +
                "7 Найти факториал числа \n" +
                "8 Возвести число в степень N \n" +
                "9 Выйти из консоли");


                MathAction = Console.ReadLine();


            if (MathAction == 1.ToString())
            {
                Console.WriteLine("Введите первое число:  ");
                double FirstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число:  ");
                double SecondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Сумма двух чисел равна:  " + (FirstNumber + SecondNumber));
            }
            else if (MathAction == 2.ToString())
            {
                Console.WriteLine("Введите первое число:  ");
                double FirstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число:  ");
                double SecondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Разность первого числа из второго равна:  " + (SecondNumber - FirstNumber));
            }
            else if (MathAction == 3.ToString())
            {
                Console.WriteLine("Введите первое число:  ");
                double FirstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число:  ");
                double SecondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Произведение двух чисел равно:  " + (SecondNumber * FirstNumber));
            }
            else if (MathAction == 4.ToString())
            {
                Console.WriteLine("Введите первое число:  ");
                double FirstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число:  ");
                double SecondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Деление первого числа на второе равно:  " + (FirstNumber / SecondNumber));
            }

            else if (MathAction == 5.ToString())
            {
                Console.WriteLine("Введите число:  ");
                double Number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Корень из данного числа равен:  " + Math.Sqrt(Number));

            }
            else if (MathAction == 6.ToString())
            {
                Console.WriteLine("Введите число:  ");
                double Number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Один процент от данного числа равен:  " + 0.01 * Number);


            }
            else if (MathAction == 7.ToString()) 
            {
                Console.WriteLine("Введите число:  ");
               int Number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= Number; i++)
                Factorial  =  Factorial * i;

                Console.WriteLine("Факториал данного числа равен:  " + Factorial);


            }
            while (MathAction == 8.ToString())
            {
                Console.WriteLine("Введите число:  ");
                int Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите степень числа:  ");
                int Pow = Convert.ToInt32(Console.ReadLine());
                for (int g = 0; g < Pow; g++)
                    PowResult *= Number;

                    Console.WriteLine("Число в данной степени равно  " + PowResult);

                
            }
            if (MathAction == 9.ToString())
            {
                return;
            }



































            Console.ReadLine();
                    }
                }
            }
       

    

