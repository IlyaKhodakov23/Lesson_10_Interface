using System.Runtime.CompilerServices;

namespace Lesson_10_Practic_2
{
    internal class Program
    {
        //Задание 2
        //Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
        //Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.

        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            //Интерфейс от логера
            Logger = new Logger();
            Calculator calculator = new Calculator(Logger);
            calculator.Sum();
        }
    }

    public interface ISum
    {
        void Sum();
    }

    public class Calculator : ISum
    {
        //Переменная логер
        ILogger Logger { get; }
        //Конструктор с параметром интерфейс
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Sum()
        {
            try
            {
                Console.WriteLine("Введите первое слагаемое:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе слагаемое:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результат сложения: {a + b}");
                Logger.Event("Расчет выполнен");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }
    }
}