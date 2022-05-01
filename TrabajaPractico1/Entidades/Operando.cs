using System;

namespace Entidades
{
    public class Operando
    {

        private double numero;

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        }

        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public double ValidarOperando(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);

            return retorno;
        }

        private bool EsBinario(string binario)
        {
            foreach (var caracterAValidar in binario)
            {
                if (caracterAValidar != '0' || caracterAValidar != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            double suma = 0;
            string retorno = "Valor inválido";

            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        suma += (int)Math.Pow(2, i);
                    }

                }
                retorno = suma.ToString();
            }
            return retorno;

        }

        public string DecimalBinario(double numero)
        {

            string binario = "";
            int auxNumero = (int)numero;

            while (auxNumero>0)
            {
                if ((auxNumero % 2)!=0)
                {
                    binario = "1" + binario;
                }else
                {
                    binario = "0" + binario;
                 
                }
                    auxNumero = auxNumero / 2;
            }

           return binario;
           
        }

        public string DecimalBinario(string strnumero)
        {
            double numero;
            string cadena;

            if (double.TryParse(strnumero, out numero))
            {
                cadena = DecimalBinario(numero);
            }
            else
            {
                cadena = "Valor inválido";
            }
            return cadena;

        }
    }//finaliza la clase 
}

