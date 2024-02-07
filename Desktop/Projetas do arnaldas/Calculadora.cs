using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace Arnaldo
{
    public class Calculadora
    {
        public delegate void Op(double num1, double num2, ref double R);

        public double num1;
        public double num2;
        public Calculadora(double aNum1, double aNum2)
        {
            this.num1 = aNum1;
            this.num2 = aNum2;
            
        }


        public void Soma(double number1, double number2, ref double R)
        {
            R = number1 + number2;
        }
        public void Subtração(double number1, double number2, ref double R)
        {
            R = number1 - number2;
        }
        public void Multiplicação(double number1, double number2, ref double R)
        {
            R = number1 * number2;
        }
        public void Divisão(double number1, double number2, ref double R)
        {
            R = number1 / number2;
        }
        
    }
}
