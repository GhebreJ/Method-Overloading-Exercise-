using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool print)
        {
            var sum = num1 + num2;

            if(print)
            {
                return (sum != 1 && sum != -1 ) ? $"{sum} dollars" : $"{sum} dollar";
            }

            return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{Add(1,0, true)}");
        }

        
    }
}
