using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = operador;

            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                retorno = '+';
            }
            return retorno;
        }

        public static double Operar (Operando num1, Operando num2, char operador)
        {
            double retorno;

            switch (ValidarOperador (operador))
            {
                    case '+':
                    retorno = num1 + num2;
                    break;
                    case '-':
                    retorno = num1 - num2;
                    break;
                    case '*':
                    retorno = num1 * num2;
                    break;
                    case '/':
                    retorno = num1 / num2;
                    break;
                    default:
                    retorno = num1 + num2;
                    break;
            }
            return retorno;

        }
    }
}
