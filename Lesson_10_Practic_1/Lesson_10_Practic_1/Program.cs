namespace Lesson_10_Practic_1
{
    internal class Program
    {
        //Задание 1
        //Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел.Определите интерфейс для функции сложения числа и реализуйте его.
        //Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое слагаемое:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе слагаемое:");
                int b = Convert.ToInt32(Console.ReadLine());
                ISum sum = new Calculator();
                int result = sum.Sum(a, b);
                Console.WriteLine($"Результат сложения: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public interface ISum
    {
        int Sum(int a, int b);
    }

    class Calculator : ISum
    {
        int ISum.Sum(int a, int b)
        {
            return a + b;
        }
    }
}