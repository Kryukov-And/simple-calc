namespace Code
{
     /// <summary>
     /// Класс, хранящий в себе переменные и итоговое значение. Так же содержит метод
     /// для выплнения операций над переменными
     /// </summary>
    public class Numbers
    {
        private double x, y, count;
        public double Count { get {return count;} set { count = value;}}
        public double X {get {return x;}}
        public double Y {get {return y;}}
    
        /// <summary>
        /// Является конструктором класса Numbers
        /// </summary>
        /// <param name="x">Значение первой переменной для конструктора</param>
        /// <param name="y">Значение второй переменной для конструктора</param>
        public Numbers(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
            /// <summary>
            /// Метод для реализации операции между двумя числами
            /// </summary>
            /// <param name="x">Значение первой переменной </param>
            /// <param name="y">Значение второй переменной</param>
            /// <param name="t">Операция, которую нужно выполнить</param>
            /// <returns>Значение, получаемое в результате выполнения операции</returns>
        public static double Check(double x, double y, char t)
        {
            switch (t)
            {
                case '+':
                    return x + y;
                default:
                    return x - y;
            }
        }

    }
}