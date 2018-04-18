using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string rtn;
            switch (operador)
            {
                case "-":
                    rtn="-";
                    break;

                case "*":
                    rtn= "*";
                    break;

                case "/":
                    rtn = "/";
                    break;
                default :
                    rtn = "+";
                    break;
            }
            return rtn;
        }

        public double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado;
            string s = ValidarOperador(operador);
            switch (s)
            {
                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
            

        }
    }
}
