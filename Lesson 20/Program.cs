using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите радиус окружности");// запрашиваем у пользователя ввод радиуса
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = LengthOfCircle;
            double d = LengthOfCircle(r);           

            myDelegate = SquarehOfCircle;
            double s = SquarehOfCircle(r);          

            myDelegate = Volume;
            double v = Volume(r);
            Console.WriteLine( $"Длина окружности = {d:f2} \nПлощадь круга = {s:f2}  \nОбъем шара = {v:f2}");
            Console.ReadKey();
        }
        static double LengthOfCircle(double r) => 2 * Math.PI * r; // Метод нахождения длины окружности
        static double SquarehOfCircle(double r) => Math.PI * Math.Pow(r,2);// Метод нахождения площади круга
        static double Volume(double r) => 4/3.0 *Math.PI * Math.Pow(r,3);// Метод нахождения объема шара


    }
}
