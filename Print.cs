namespace Code
{
     /// <summary>
     /// Класс, выполняющий роль "интерфейса". Содержит в себе 2 метода вызова текста на экран
     /// </summary>
    public class Print
    {
        public static void Print_Text_1()
        {
            System.Console.WriteLine("Enter 2 numbers: ");
        }

        public static void Print_Text_2()
        {
            System.Console.WriteLine("Enter one of following symbols: ");
            System.Console.WriteLine("+ for addition");
            System.Console.WriteLine("- fo subtraction");
            System.Console.WriteLine("* for multiply");
            System.Console.WriteLine("/ for division");
            System.Console.WriteLine("p for power");
            System.Console.WriteLine("g for gcd");
            System.Console.WriteLine("l for lcm");
        }

        public static void Hello_Message()
        {
            System.Console.WriteLine("Welcome, please follow instructions");
        }
    }
}