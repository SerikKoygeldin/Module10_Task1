using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module10_Task1
{
    public interface ICalculator
    {
        int Addition(int a, int b);
    }

    public class Calculator : ICalculator
    {
        public int Addition(int a,int b) 
        {     
          return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a + b = ?");
                Console.WriteLine("Введите значение a:");

                int a = 0;
                int.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Введите значение b:");

                int b = 0;
                int.TryParse(Console.ReadLine(), out b);

                Calculator calculator = new Calculator();

                int result = calculator.Addition(a, b);
                Console.WriteLine("a + b = {0}", result);
                Console.ReadKey(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }    
        }
    }
}
