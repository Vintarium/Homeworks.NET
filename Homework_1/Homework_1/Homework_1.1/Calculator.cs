using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.NET.Homework_1.Homework_1._1
{
    public class Calculator
    {
        public static double Add(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }

        public static double Subtract(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }

        public static double Multiply(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }

        public static double Divide(double firstOperand, double secondOperand)
        {
            if (secondOperand == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзя!");

            }
            return firstOperand / secondOperand;
        }

    }
}
