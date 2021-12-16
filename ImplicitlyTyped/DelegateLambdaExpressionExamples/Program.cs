using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdaExpressionExamples
{
    class Program
    {
        delegate int CalculatorHandler(int f, int s);
        static void Main(string[] args)
        {
            CalculatorHandler addMethod = Sub;
            int result = addMethod(2, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int Add(int firstName, int secondNumber)
        {
            return firstName + secondNumber;
        }
        static int Sub(int firstName, int secondNumber)
        {
            return firstName - secondNumber;
        }
        static int Multi(int firstName, int secondNumber)
        {
            return firstName * secondNumber;
        }
        static int Div(int firstName, int secondNumber)
        {
            return firstName / secondNumber;
        }
    }
}
