using System;

namespace Code
{   

     /// <summary>
     ///  Основной класс программы
     /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Print.Print_Text_1();

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            
            Numbers Num = new Numbers(x, y);
            
            Print.Print_Text_2();

            Char r;

            r = (char)Console.Read();

            Num.Count = Numbers.Check(Num.X, Num.Y, r);

            System.Console.WriteLine($"{Num.Count}");
        }
    }
}
